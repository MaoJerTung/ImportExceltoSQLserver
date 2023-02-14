<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Application
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextFilename = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboSheet = New System.Windows.Forms.ComboBox()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.WHCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatedataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotshipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotOwnerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PMADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PMAGroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OwnerPlannerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlannerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupNSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RankTopคลงDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProNSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProNSDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendorCodeNSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendorNameNSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C2ValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotShipBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotShipBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WHCodeDataGridViewTextBoxColumn, Me.WHDataGridViewTextBoxColumn, Me.DatedataDataGridViewTextBoxColumn, Me.ITEMIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.PackDataGridViewTextBoxColumn, Me.OrderDataGridViewTextBoxColumn, Me.NotshipDataGridViewTextBoxColumn, Me.NotCodeDataGridViewTextBoxColumn, Me.ReasonDataGridViewTextBoxColumn, Me.NotOwnerDataGridViewTextBoxColumn, Me.PMADataGridViewTextBoxColumn, Me.PMAGroupDataGridViewTextBoxColumn, Me.OwnerPlannerDataGridViewTextBoxColumn, Me.PlannerDataGridViewTextBoxColumn, Me.GroupNSDataGridViewTextBoxColumn, Me.RankTopคลงDataGridViewTextBoxColumn, Me.ProNSDataGridViewTextBoxColumn, Me.ProNSDateDataGridViewTextBoxColumn, Me.VendorCodeNSDataGridViewTextBoxColumn, Me.VendorNameNSDataGridViewTextBoxColumn, Me.C2DataGridViewTextBoxColumn, Me.C2ValueDataGridViewTextBoxColumn, Me.RetailDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3})
        Me.DataGridView1.DataSource = Me.NotShipBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1035, 367)
        Me.DataGridView1.TabIndex = 0
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Location = New System.Drawing.Point(951, 400)
        Me.BtnBrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(100, 28)
        Me.BtnBrowse.TabIndex = 1
        Me.BtnBrowse.Text = "Browse"
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 406)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "File name:"
        '
        'TextFilename
        '
        Me.TextFilename.Location = New System.Drawing.Point(93, 402)
        Me.TextFilename.Margin = New System.Windows.Forms.Padding(4)
        Me.TextFilename.Name = "TextFilename"
        Me.TextFilename.ReadOnly = True
        Me.TextFilename.Size = New System.Drawing.Size(848, 22)
        Me.TextFilename.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 434)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sheet:"
        '
        'cboSheet
        '
        Me.cboSheet.FormattingEnabled = True
        Me.cboSheet.Location = New System.Drawing.Point(93, 434)
        Me.cboSheet.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSheet.Name = "cboSheet"
        Me.cboSheet.Size = New System.Drawing.Size(160, 24)
        Me.cboSheet.TabIndex = 5
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(263, 434)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(100, 28)
        Me.btnImport.TabIndex = 6
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'WHCodeDataGridViewTextBoxColumn
        '
        Me.WHCodeDataGridViewTextBoxColumn.DataPropertyName = "WH_Code"
        Me.WHCodeDataGridViewTextBoxColumn.HeaderText = "WH_Code"
        Me.WHCodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WHCodeDataGridViewTextBoxColumn.Name = "WHCodeDataGridViewTextBoxColumn"
        Me.WHCodeDataGridViewTextBoxColumn.Width = 125
        '
        'WHDataGridViewTextBoxColumn
        '
        Me.WHDataGridViewTextBoxColumn.DataPropertyName = "WH"
        Me.WHDataGridViewTextBoxColumn.HeaderText = "WH"
        Me.WHDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WHDataGridViewTextBoxColumn.Name = "WHDataGridViewTextBoxColumn"
        Me.WHDataGridViewTextBoxColumn.Width = 125
        '
        'DatedataDataGridViewTextBoxColumn
        '
        Me.DatedataDataGridViewTextBoxColumn.DataPropertyName = "Datedata"
        Me.DatedataDataGridViewTextBoxColumn.HeaderText = "Datedata"
        Me.DatedataDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DatedataDataGridViewTextBoxColumn.Name = "DatedataDataGridViewTextBoxColumn"
        Me.DatedataDataGridViewTextBoxColumn.Width = 125
        '
        'ITEMIDDataGridViewTextBoxColumn
        '
        Me.ITEMIDDataGridViewTextBoxColumn.DataPropertyName = "ITEM_ID"
        Me.ITEMIDDataGridViewTextBoxColumn.HeaderText = "ITEM_ID"
        Me.ITEMIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ITEMIDDataGridViewTextBoxColumn.Name = "ITEMIDDataGridViewTextBoxColumn"
        Me.ITEMIDDataGridViewTextBoxColumn.Width = 125
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.Width = 125
        '
        'PackDataGridViewTextBoxColumn
        '
        Me.PackDataGridViewTextBoxColumn.DataPropertyName = "Pack"
        Me.PackDataGridViewTextBoxColumn.HeaderText = "Pack"
        Me.PackDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PackDataGridViewTextBoxColumn.Name = "PackDataGridViewTextBoxColumn"
        Me.PackDataGridViewTextBoxColumn.Width = 125
        '
        'OrderDataGridViewTextBoxColumn
        '
        Me.OrderDataGridViewTextBoxColumn.DataPropertyName = "Order"
        Me.OrderDataGridViewTextBoxColumn.HeaderText = "Order"
        Me.OrderDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrderDataGridViewTextBoxColumn.Name = "OrderDataGridViewTextBoxColumn"
        Me.OrderDataGridViewTextBoxColumn.Width = 125
        '
        'NotshipDataGridViewTextBoxColumn
        '
        Me.NotshipDataGridViewTextBoxColumn.DataPropertyName = "Notship"
        Me.NotshipDataGridViewTextBoxColumn.HeaderText = "Notship"
        Me.NotshipDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NotshipDataGridViewTextBoxColumn.Name = "NotshipDataGridViewTextBoxColumn"
        Me.NotshipDataGridViewTextBoxColumn.Width = 125
        '
        'NotCodeDataGridViewTextBoxColumn
        '
        Me.NotCodeDataGridViewTextBoxColumn.DataPropertyName = "NotCode"
        Me.NotCodeDataGridViewTextBoxColumn.HeaderText = "NotCode"
        Me.NotCodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NotCodeDataGridViewTextBoxColumn.Name = "NotCodeDataGridViewTextBoxColumn"
        Me.NotCodeDataGridViewTextBoxColumn.Width = 125
        '
        'ReasonDataGridViewTextBoxColumn
        '
        Me.ReasonDataGridViewTextBoxColumn.DataPropertyName = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.HeaderText = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ReasonDataGridViewTextBoxColumn.Name = "ReasonDataGridViewTextBoxColumn"
        Me.ReasonDataGridViewTextBoxColumn.Width = 125
        '
        'NotOwnerDataGridViewTextBoxColumn
        '
        Me.NotOwnerDataGridViewTextBoxColumn.DataPropertyName = "NotOwner"
        Me.NotOwnerDataGridViewTextBoxColumn.HeaderText = "NotOwner"
        Me.NotOwnerDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NotOwnerDataGridViewTextBoxColumn.Name = "NotOwnerDataGridViewTextBoxColumn"
        Me.NotOwnerDataGridViewTextBoxColumn.Width = 125
        '
        'PMADataGridViewTextBoxColumn
        '
        Me.PMADataGridViewTextBoxColumn.DataPropertyName = "PMA"
        Me.PMADataGridViewTextBoxColumn.HeaderText = "PMA"
        Me.PMADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PMADataGridViewTextBoxColumn.Name = "PMADataGridViewTextBoxColumn"
        Me.PMADataGridViewTextBoxColumn.Width = 125
        '
        'PMAGroupDataGridViewTextBoxColumn
        '
        Me.PMAGroupDataGridViewTextBoxColumn.DataPropertyName = "PMA_Group"
        Me.PMAGroupDataGridViewTextBoxColumn.HeaderText = "PMA_Group"
        Me.PMAGroupDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PMAGroupDataGridViewTextBoxColumn.Name = "PMAGroupDataGridViewTextBoxColumn"
        Me.PMAGroupDataGridViewTextBoxColumn.Width = 125
        '
        'OwnerPlannerDataGridViewTextBoxColumn
        '
        Me.OwnerPlannerDataGridViewTextBoxColumn.DataPropertyName = "Owner_Planner"
        Me.OwnerPlannerDataGridViewTextBoxColumn.HeaderText = "Owner_Planner"
        Me.OwnerPlannerDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OwnerPlannerDataGridViewTextBoxColumn.Name = "OwnerPlannerDataGridViewTextBoxColumn"
        Me.OwnerPlannerDataGridViewTextBoxColumn.Width = 125
        '
        'PlannerDataGridViewTextBoxColumn
        '
        Me.PlannerDataGridViewTextBoxColumn.DataPropertyName = "Planner"
        Me.PlannerDataGridViewTextBoxColumn.HeaderText = "Planner"
        Me.PlannerDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PlannerDataGridViewTextBoxColumn.Name = "PlannerDataGridViewTextBoxColumn"
        Me.PlannerDataGridViewTextBoxColumn.Width = 125
        '
        'GroupNSDataGridViewTextBoxColumn
        '
        Me.GroupNSDataGridViewTextBoxColumn.DataPropertyName = "Group_NS"
        Me.GroupNSDataGridViewTextBoxColumn.HeaderText = "Group_NS"
        Me.GroupNSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GroupNSDataGridViewTextBoxColumn.Name = "GroupNSDataGridViewTextBoxColumn"
        Me.GroupNSDataGridViewTextBoxColumn.Width = 125
        '
        'RankTopคลงDataGridViewTextBoxColumn
        '
        Me.RankTopคลงDataGridViewTextBoxColumn.DataPropertyName = "Rank_Top_คลัง"
        Me.RankTopคลงDataGridViewTextBoxColumn.HeaderText = "Rank_Top_คลัง"
        Me.RankTopคลงDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RankTopคลงDataGridViewTextBoxColumn.Name = "RankTopคลงDataGridViewTextBoxColumn"
        Me.RankTopคลงDataGridViewTextBoxColumn.Width = 125
        '
        'ProNSDataGridViewTextBoxColumn
        '
        Me.ProNSDataGridViewTextBoxColumn.DataPropertyName = "Pro_NS"
        Me.ProNSDataGridViewTextBoxColumn.HeaderText = "Pro_NS"
        Me.ProNSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProNSDataGridViewTextBoxColumn.Name = "ProNSDataGridViewTextBoxColumn"
        Me.ProNSDataGridViewTextBoxColumn.Width = 125
        '
        'ProNSDateDataGridViewTextBoxColumn
        '
        Me.ProNSDateDataGridViewTextBoxColumn.DataPropertyName = "Pro_NS_Date"
        Me.ProNSDateDataGridViewTextBoxColumn.HeaderText = "Pro_NS_Date"
        Me.ProNSDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProNSDateDataGridViewTextBoxColumn.Name = "ProNSDateDataGridViewTextBoxColumn"
        Me.ProNSDateDataGridViewTextBoxColumn.Width = 125
        '
        'VendorCodeNSDataGridViewTextBoxColumn
        '
        Me.VendorCodeNSDataGridViewTextBoxColumn.DataPropertyName = "Vendor_Code_NS"
        Me.VendorCodeNSDataGridViewTextBoxColumn.HeaderText = "Vendor_Code_NS"
        Me.VendorCodeNSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.VendorCodeNSDataGridViewTextBoxColumn.Name = "VendorCodeNSDataGridViewTextBoxColumn"
        Me.VendorCodeNSDataGridViewTextBoxColumn.Width = 125
        '
        'VendorNameNSDataGridViewTextBoxColumn
        '
        Me.VendorNameNSDataGridViewTextBoxColumn.DataPropertyName = "Vendor_Name_NS"
        Me.VendorNameNSDataGridViewTextBoxColumn.HeaderText = "Vendor_Name_NS"
        Me.VendorNameNSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.VendorNameNSDataGridViewTextBoxColumn.Name = "VendorNameNSDataGridViewTextBoxColumn"
        Me.VendorNameNSDataGridViewTextBoxColumn.Width = 125
        '
        'C2DataGridViewTextBoxColumn
        '
        Me.C2DataGridViewTextBoxColumn.DataPropertyName = "C2"
        Me.C2DataGridViewTextBoxColumn.HeaderText = "C2"
        Me.C2DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.C2DataGridViewTextBoxColumn.Name = "C2DataGridViewTextBoxColumn"
        Me.C2DataGridViewTextBoxColumn.Width = 125
        '
        'C2ValueDataGridViewTextBoxColumn
        '
        Me.C2ValueDataGridViewTextBoxColumn.DataPropertyName = "C2_Value"
        Me.C2ValueDataGridViewTextBoxColumn.HeaderText = "C2_Value"
        Me.C2ValueDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.C2ValueDataGridViewTextBoxColumn.Name = "C2ValueDataGridViewTextBoxColumn"
        Me.C2ValueDataGridViewTextBoxColumn.Width = 125
        '
        'RetailDataGridViewTextBoxColumn
        '
        Me.RetailDataGridViewTextBoxColumn.DataPropertyName = "Retail"
        Me.RetailDataGridViewTextBoxColumn.HeaderText = "Retail"
        Me.RetailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RetailDataGridViewTextBoxColumn.Name = "RetailDataGridViewTextBoxColumn"
        Me.RetailDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Retail_Value"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Retail_Value"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SKIP_ORDER"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SKIP_ORDER"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'NotShipBindingSource
        '
        Me.NotShipBindingSource.DataSource = GetType(ImportExceltoSQLserver.NotShip)
        '
        'Application
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.cboSheet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextFilename)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Application"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImportData .xlsx File"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotShipBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextFilename As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboSheet As ComboBox
    Friend WithEvents btnImport As Button
    Friend WithEvents RetailValueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SKIPORDERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents WHCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatedataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PackDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotshipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReasonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotOwnerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PMADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PMAGroupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OwnerPlannerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlannerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupNSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RankTopคลงDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProNSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProNSDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VendorCodeNSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VendorNameNSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents C2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents C2ValueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RetailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents NotShipBindingSource As BindingSource
End Class
