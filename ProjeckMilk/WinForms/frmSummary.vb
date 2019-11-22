Imports Syncfusion.XlsIO
Public Class frmSummary
    Dim j As Integer
    Public columCount As Int64
    Public HeaderS As String
    Public rows(1000, 8) As String
    Public row As String
    Private lPageNo As String = ""
    Private sPageNo As String = ""
    Private oStringFormat As StringFormat
    Private oStringFormatComboBox As StringFormat
    Private oButton As Button
    Private oCheckbox As CheckBox
    Private oComboBox As ComboBox
    Private nTotalWidth As Int16
    Private nRowPos As Int16
    Private NewPage As Boolean
    Private nPageNo As Int16
    Private Header As String

    Private Sub frmSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ToothImageDBDataSet.ServiceRecordDB' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'PLDBDataSet.serviceRecord' table. You can move, or remove it, as needed.
        'DataGridView1.Columns(4).DefaultCellStyle.Format = "dd/MM/yyyy"
        If DataGridView1.Rows.Count > 0 Then
            btnExportExcel.Enabled = True
        Else
            btnExportExcel.Enabled = False
        End If
        j = 2
        Try
            ToothImageDBDataSet.Clear()
            ToothImageDBDataSet.EnforceConstraints = False
            Me.ServiceRecordDBTableAdapter.Fill(Me.ToothImageDBDataSet.ServiceRecordDB)
        Catch ex As Exception
            'MsgBox("Cannot access database file. Please check the database connection.", vbCritical, "Database Error")
            MsgBox(ex.ToString, vbCritical, "Exception Error")
            End
        End Try
        DataGridView1.Columns(0).Visible = False
        Dim dv As DataView = New DataView
        Dim dat As String = dtpSummaryFrom.Value.ToShortDateString
        dv.Table = ToothImageDBDataSet.ServiceRecordDB
        dv.RowFilter = "ServiceDate = '" & dat & "'"
        DataGridView1.DataSource = dv
        Dim sum As Integer
        For i As Integer = 0 To DataGridView1.RowCount - 1
            sum += DataGridView1.Rows(i).Cells(9).Value
        Next
        lblSummaryTotal.Text = "Total Income for " + dtpSummaryFrom.Value.ToShortDateString() + ":"
        lblSummaryIncome.Text = "P" + sum.ToString()
        lblSummaryTotal.Visible = True
        lblSummaryIncome.Visible = True
        lblSummaryNote.Visible = False
        lblSummaryNote2.Visible = False
    End Sub

    Private Sub dtpSummaryFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpSummaryFrom.ValueChanged
        Dim dv As DataView = New DataView
        Dim dat As String = dtpSummaryFrom.Value.ToShortDateString
        j = 1
        dv.Table = ToothImageDBDataSet.ServiceRecordDB
        dv.RowFilter = "ServiceDate = '" & dat & "'"
        DataGridView1.DataSource = dv
        Dim sum As Integer
        For i As Integer = 0 To DataGridView1.RowCount - 1
            sum += DataGridView1.Rows(i).Cells(9).Value
        Next
        lblSummaryTotal.Text = "Total Income for " + dtpSummaryFrom.Value.ToShortDateString() + ":"
        lblSummaryIncome.Text = "P" + sum.ToString()
        lblSummaryTotal.Visible = True
        lblSummaryIncome.Visible = True
        lblSummaryNote.Visible = False
        lblSummaryNote2.Visible = False
        If DataGridView1.Rows.Count > 0 Then
            btnExportExcel.Enabled = True
        Else
            btnExportExcel.Enabled = False
        End If
    End Sub
    Private Sub PrintDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintDocument.Click


        PrintDialog1.AllowSomePages = True
        PrintDialog1.ShowHelp = True
        PrintDialog1.Document = PrintDocument1

        Dim result As DialogResult = PrintDialog1.ShowDialog()
        If (result = DialogResult.OK) Then
            PrintDocument1.Print()
        End If
    End Sub
    Private Sub PrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreview.Click


        Dim dlg As New PrintPreviewDialog()
        Dim d

        dlg.Document = PrintDocument1
        d = PrintDocument1.DefaultPageSettings.Bounds

        dlg.ShowIcon = False
        dlg.ShowDialog()
    End Sub
    Private Sub PageSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageSetup.Click
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.AllowOrientation = True
        PageSetupDialog1.AllowPrinter = True
        Dim result As DialogResult = PageSetupDialog1.ShowDialog
    End Sub


    Private Sub InitializeDataGridView()
        DataGridView1.ColumnCount = columCount
        DataGridView1.ColumnHeadersVisible = True
        DataGridView1.RowHeadersVisible = True
        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.BackColor = Color.White
        columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
        DataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle
    End Sub

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint

        oStringFormat = New StringFormat
        oStringFormat.Alignment = StringAlignment.Near
        oStringFormat.LineAlignment = StringAlignment.Center
        oStringFormat.Trimming = StringTrimming.EllipsisCharacter

        oStringFormatComboBox = New StringFormat
        oStringFormatComboBox.LineAlignment = StringAlignment.Center
        oStringFormatComboBox.FormatFlags = StringFormatFlags.NoWrap
        oStringFormatComboBox.Trimming = StringTrimming.EllipsisCharacter

        oButton = New Button
        oCheckbox = New CheckBox
        oComboBox = New ComboBox

        nTotalWidth = 0
        For Each oColumn As DataGridViewColumn In DataGridView1.Columns

            nTotalWidth += oColumn.Width

        Next
        nPageNo = 1
        NewPage = True
        nRowPos = 0



    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Static oColumnLefts As New ArrayList
        Static oColumnWidths As New ArrayList
        Static oColumnTypes As New ArrayList
        Static nHeight As Int16

        Dim nWidth, i, nRowsPerPage As Int16
        Dim nTop As Int16 = e.MarginBounds.Top
        Dim nLeft As Int16 = e.MarginBounds.Left

        If nPageNo = 1 Then
            oColumnLefts.Clear()
            oColumnWidths.Clear()
            oColumnTypes.Clear()
            For Each oColumn As DataGridViewColumn In DataGridView1.Columns
                nWidth = CType(Math.Floor(oColumn.Width / nTotalWidth * nTotalWidth * (e.MarginBounds.Width / nTotalWidth)), Int16)
                nHeight = e.Graphics.MeasureString(oColumn.HeaderText, oColumn.InheritedStyle.Font, nWidth).Height + 11
                oColumnLefts.Add(nLeft)
                oColumnWidths.Add(nWidth)
                oColumnTypes.Add(oColumn.GetType)
                nLeft += nWidth
            Next
        End If
        Do While nRowPos < DataGridView1.Rows.Count
            Dim oRow As DataGridViewRow = DataGridView1.Rows(nRowPos)
            If nTop + nHeight >= e.MarginBounds.Height + e.MarginBounds.Top Then
                DrawFooter(e, nRowsPerPage)
                NewPage = True
                nPageNo += 1
                e.HasMorePages = True
                Exit Sub
            Else
                If NewPage Then
                    ' Draw Header
                    e.Graphics.DrawString("Total: " + lblSummaryIncome.Text, New Font(lblSummarySH.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - e.Graphics.MeasureString("Total: " + lblSummaryIncome.Text, New Font(lblSummarySH.Font, FontStyle.Bold), e.MarginBounds.Width).Height - 24)
                    If j = 0 Then
                        e.Graphics.DrawString(" DATE: OVERALL", New Font(lblSummaryTotal.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - e.Graphics.MeasureString(" DATE: OVERALL", New Font(lblSummaryTotal.Font, FontStyle.Bold), e.MarginBounds.Width).Height - 7)
                    ElseIf j = 1 Or j = 2 Then
                        e.Graphics.DrawString(" DATE: " + dtpSummaryFrom.Value.ToShortDateString, New Font(lblSummaryTotal.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - e.Graphics.MeasureString(" DATE: " + dtpSummaryFrom.Value.ToShortDateString, New Font(lblSummaryTotal.Font, FontStyle.Bold), e.MarginBounds.Width).Height - 7)
                    End If
                    ' Draw Columns
                    nTop = e.MarginBounds.Top
                    i = 0
                    For Each oColumn As DataGridViewColumn In DataGridView1.Columns
                        e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGray), New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                        e.Graphics.DrawString(oColumn.HeaderText, oColumn.InheritedStyle.Font, New SolidBrush(oColumn.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)
                        i += 1
                    Next
                    NewPage = False
                End If
                nTop += nHeight
                i = 0
                Dim svalue As String
                For Each oCell As DataGridViewCell In oRow.Cells
                    If oCell.Value <> Nothing Then
                        svalue = oCell.Value.ToString
                    Else
                        svalue = ""
                    End If
                    If oColumnTypes(i) Is GetType(DataGridViewTextBoxColumn) OrElse oColumnTypes(i) Is GetType(DataGridViewLinkColumn) Then
                        e.Graphics.DrawString(svalue, oCell.InheritedStyle.Font, New SolidBrush(oCell.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)
                    ElseIf oColumnTypes(i) Is GetType(DataGridViewButtonColumn) Then
                        oButton.Text = oCell.Value.ToString
                        oButton.Size = New Size(oColumnWidths(i), nHeight)
                        Dim oBitmap As New Bitmap(oButton.Width, oButton.Height)
                        oButton.DrawToBitmap(oBitmap, New Rectangle(0, 0, oBitmap.Width, _
                                                                    oBitmap.Height))
                        e.Graphics.DrawImage(oBitmap, New Point(oColumnLefts(i), nTop))
                    ElseIf oColumnTypes(i) Is GetType(DataGridViewCheckBoxColumn) Then
                        oCheckbox.Size = New Size(14, 14)
                        oCheckbox.Checked = CType(oCell.Value, Boolean)
                        Dim oBitmap As New Bitmap(oColumnWidths(i), nHeight)
                        Dim oTempGraphics As Graphics = Graphics.FromImage(oBitmap)
                        oTempGraphics.FillRectangle(Brushes.White, New Rectangle(0, _
                                                    0, oBitmap.Width, oBitmap.Height))
                        oCheckbox.DrawToBitmap(oBitmap, New Rectangle(CType((oBitmap.Width _
                                  - oCheckbox.Width) / 2, Int32), CType((oBitmap.Height _
                                  - oCheckbox.Height) / 2, Int32), oCheckbox.Width, _
                                  oCheckbox.Height))
                        e.Graphics.DrawImage(oBitmap, New Point(oColumnLefts(i), nTop))
                    ElseIf oColumnTypes(i) Is GetType(DataGridViewComboBoxColumn) Then
                        oComboBox.Size = New Size(oColumnWidths(i), nHeight)
                        Dim oBitmap As New Bitmap(oComboBox.Width, oComboBox.Height)
                        oComboBox.DrawToBitmap(oBitmap, New Rectangle(0, 0, oBitmap.Width, _
                                                                      oBitmap.Height))
                        e.Graphics.DrawImage(oBitmap, New Point(oColumnLefts(i), nTop))
                        e.Graphics.DrawString(oCell.Value.ToString, oCell.InheritedStyle.Font, _
                                   New SolidBrush(oCell.InheritedStyle.ForeColor), New  _
                                   RectangleF(oColumnLefts(i) + 1, nTop, oColumnWidths(i) _
                                   - 16, nHeight), oStringFormatComboBox)
                    ElseIf oColumnTypes(i) Is GetType(DataGridViewImageColumn) Then
                        Dim oCellSize As Rectangle = New Rectangle(oColumnLefts(i), nTop, _
                                                                   oColumnWidths(i), nHeight)
                        Dim oImageSize As Size = CType(oCell.Value, Image).Size
                        e.Graphics.DrawImage(oCell.Value, New Rectangle(oColumnLefts(i) _
                                   + CType(((oCellSize.Width _
                                   - oImageSize.Width) / 2), Int32), nTop + CType _
                                   (((oCellSize.Height - oImageSize.Height) / 2), Int32), _
                                   CType(oCell.Value, Image).Width, CType(oCell.Value,  _
                                   Image).Height))
                    End If
                    e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), _
                                                         nTop, oColumnWidths(i), nHeight))
                    i += 1
                Next
            End If
            nRowPos += 1
            nRowsPerPage += 1
        Loop
        DrawFooter(e, nRowsPerPage)
        e.HasMorePages = False
    End Sub

    Private Sub DrawFooter(ByVal e As System.Drawing.Printing.PrintPageEventArgs, _
                           ByVal RowsPerPage As Int32)

        Dim sPageNo As String = nPageNo.ToString + " of "
        If nPageNo = "1" Then
            ' rowsC = Math.Ceiling(DataGridView1.Rows.Count - 1)
            lPageNo = Math.Ceiling((DataGridView1.Rows.Count) / RowsPerPage).ToString()
            sPageNo = nPageNo.ToString + " of " + lPageNo
        Else
            sPageNo = nPageNo.ToString + " of " + lPageNo
        End If


        e.Graphics.DrawString("Admin: " + MainFormMetro.admin, DataGridView1.Font, Brushes.Black,
                              e.MarginBounds.Left + (e.MarginBounds.Width -
                              e.Graphics.MeasureString(sPageNo, DataGridView1.Font,
                              e.MarginBounds.Width).Width), e.MarginBounds.Top +
                              e.MarginBounds.Height + 7)

        e.Graphics.DrawString("Date Printed: " + Now.ToLongDateString + " " + Now.ToShortTimeString, _
                              DataGridView1.Font, Brushes.Black, e.MarginBounds.Left, _
                              e.MarginBounds.Top + e.MarginBounds.Height + 7)

        e.Graphics.DrawString(sPageNo, DataGridView1.Font, _
                              Brushes.Black, e.MarginBounds.Left + _
                              (e.MarginBounds.Width - e.Graphics.MeasureString(sPageNo, _
                               DataGridView1.Font, e.MarginBounds.Width).Width) / 2, _
                               e.MarginBounds.Top + e.MarginBounds.Height + 31)
    End Sub
    Private Sub btnSummaryAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSummaryAll.Click
        Dim dv As DataView = New DataView
        j = 0
        dv.Table = ToothImageDBDataSet.ServiceRecordDB
        DataGridView1.DataSource = dv
        Dim sum As Integer
        For i As Integer = 0 To DataGridView1.RowCount - 1
            sum += DataGridView1.Rows(i).Cells(9).Value
        Next
        lblSummaryTotal.Text = "Overall Income:"
        lblSummaryIncome.Text = "P" + sum.ToString()
        lblSummaryTotal.Visible = True
        lblSummaryIncome.Visible = True
        lblSummaryNote.Visible = True
        lblSummaryNote2.Visible = True
        If DataGridView1.Rows.Count > 0 Then
            btnExportExcel.Enabled = True
        Else
            btnExportExcel.Enabled = False
        End If
    End Sub
    Private Sub frmSummary_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MainFormMetro.ButtonAdv3.Enabled = True
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        Try
            Using excelEngine As ExcelEngine = New ExcelEngine()
                Dim application As IApplication = excelEngine.Excel
                application.DefaultVersion = ExcelVersion.Excel2016
                Dim workbook As IWorkbook = application.Workbooks.Create(1)
                If j = 0 Then
                    Dim worksheet As IWorksheet = workbook.Worksheets.Create("Overall")
                    worksheet = workbook.Worksheets("Overall")
                    worksheet.ImportDataGridView(DataGridView1, 1, 1, True, True)
                    worksheet.DeleteColumn(12)
                    workbook.Worksheets(0).Remove()
                    Dim dialog As New SaveFileDialog With {
                    .Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                    .FilterIndex = 1,
                    .RestoreDirectory = True
                }
                    If j = 0 Then
                        dialog.FileName = "Overall"
                    ElseIf j = 1 Or j = 2 Then
                        dialog.FileName = "Daily_" + dtpSummaryFrom.Value.ToString("dd") + "_" + dtpSummaryFrom.Value.ToString("MMM") + "_" + dtpSummaryFrom.Value.ToString("yyyy")
                    End If

                    If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        If j = 0 Then
                            workbook.SaveAs(dialog.FileName)
                            MessageBox.Show("Overall report was exported successfully")
                        ElseIf j = 1 Or j = 2 Then
                            workbook.SaveAs(dialog.FileName)
                            MessageBox.Show("Daily report for " + dtpSummaryFrom.Value.ToShortDateString + " was exported successfully")
                        End If
                    End If
                ElseIf j = 1 Or j = 2 Then
                    Dim worksheet As IWorksheet = workbook.Worksheets.Create("Daily_" + dtpSummaryFrom.Value.ToString("dd") + "_" + dtpSummaryFrom.Value.ToString("MMM") + "_" + dtpSummaryFrom.Value.ToString("yyyy"))
                    worksheet = workbook.Worksheets("Daily_" + dtpSummaryFrom.Value.ToString("dd") + "_" + dtpSummaryFrom.Value.ToString("MMM") + "_" + dtpSummaryFrom.Value.ToString("yyyy"))
                    worksheet.ImportDataGridView(DataGridView1, 1, 1, True, True)
                    worksheet.DeleteColumn(12)
                    workbook.Worksheets(0).Remove()
                    Dim dialog As New SaveFileDialog With {
                    .Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                    .FilterIndex = 1,
                    .RestoreDirectory = True
                }
                    If j = 0 Then
                        dialog.FileName = "Overall"
                    ElseIf j = 1 Or j = 2 Then
                        dialog.FileName = "Daily_" + dtpSummaryFrom.Value.ToString("dd") + "_" + dtpSummaryFrom.Value.ToString("MMM") + "_" + dtpSummaryFrom.Value.ToString("yyyy")
                    End If

                    If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        If j = 0 Then
                            workbook.SaveAs(dialog.FileName)
                            MessageBox.Show("Overall report was exported successfully")
                        ElseIf j = 1 Or j = 2 Then
                            workbook.SaveAs(dialog.FileName)
                            MessageBox.Show("Daily report for " + dtpSummaryFrom.Value.ToShortDateString + " was exported successfully")
                        End If
                    End If
                End If
                workbook = Nothing
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class