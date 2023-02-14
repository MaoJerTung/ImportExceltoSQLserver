Imports System.Data.SqlClient
Imports System.IO
Imports ExcelDataReader
Imports Z.Dapper.Plus

Public Class Application
    Dim tables As DataTableCollection
    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Excel 97 - 2003 Workbook|*.xls|Excel Workbook|*.xlsx|All files (*.*)|*.*"}
            If ofd.ShowDialog() = DialogResult.OK Then
                TextFilename.Text = ofd.FileName
                Using stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read)
                    Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                        Dim result As DataSet = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                                                                 .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                                                                 .UseHeaderRow = True}})
                        tables = result.Tables
                        cboSheet.Items.Clear()
                        For Each table As DataTable In tables
                            cboSheet.Items.Add(table.TableName)
                        Next
                    End Using
                End Using
            End If
        End Using
    End Sub

    Private Sub cboSheet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSheet.SelectedIndexChanged
        Dim dt As DataTable = tables(cboSheet.SelectedItem.ToString())
        'DataGridView1.DataSource = dt
        If dt IsNot Nothing Then
            Dim list As List(Of NotShip) = New List(Of NotShip)()
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim notship As NotShip = New NotShip()
                notship.WH_Code = dt.Rows(i)("WH_Code").ToString()
                notship.WH = dt.Rows(i)("WH").ToString()
                notship.Datedata = dt.Rows(i)("Date").ToString()
                notship.ITEM_ID = dt.Rows(i)("ITEM ID").ToString()
                notship.Product_Name = dt.Rows(i)("Product Name").ToString()
                notship.Pack = dt.Rows(i)("Pack").ToString()
                notship.Order = dt.Rows(i)("Order").ToString()
                notship.Notship = dt.Rows(i)("Notship").ToString()
                notship.NotCode = dt.Rows(i)("NotCode").ToString()
                notship.Reason = dt.Rows(i)("Reason").ToString()
                notship.NotOwner = dt.Rows(i)("NotOwner").ToString()
                notship.PMA = dt.Rows(i)("PMA").ToString()
                notship.PMA_Group = dt.Rows(i)("PMA Group").ToString()
                notship.Owner_Planner = dt.Rows(i)("Owner_Planner").ToString()
                notship.Planner = dt.Rows(i)("Planner").ToString()
                notship.Group_NS = dt.Rows(i)("Group_NS").ToString()
                notship.Rank_Top_คลัง = dt.Rows(i)("Rank Top คลัง").ToString()
                notship.Pro_NS = dt.Rows(i)("Pro_NS").ToString()
                notship.Pro_NS_Date = dt.Rows(i)("Pro_NS_Date").ToString()
                notship.Vendor_Code_NS = dt.Rows(i)("Vendor Code_NS").ToString()
                notship.Vendor_Name_NS = dt.Rows(i)("Vendor Name_NS").ToString()
                notship.C2 = dt.Rows(i)("C2").ToString()
                notship.C2_Value = dt.Rows(i)("C2 Value").ToString()
                notship.Retail = dt.Rows(i)("Retail").ToString()
                notship.Retail_Value = dt.Rows(i)("Retail Value").ToString()
                notship.SKIP_ORDER = dt.Rows(i)("SKIP ORDER").ToString()
                list.Add(notship)
            Next
            NotShipBindingSource.DataSource = list
        End If
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Try
            Dim list As List(Of NotShip) = TryCast(NotShipBindingSource.DataSource, List(Of NotShip))
            If list IsNot Nothing Then
                DapperPlusManager.Entity(Of NotShip).Table("NotShip")
                Using db As IDbConnection = New SqlConnection("Server=200.1.7.119;Database=testDB;User Id=sa;Password=gosoftthailand;")
                    db.BulkInsert(list)
                End Using
                MessageBox.Show("Complete!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
