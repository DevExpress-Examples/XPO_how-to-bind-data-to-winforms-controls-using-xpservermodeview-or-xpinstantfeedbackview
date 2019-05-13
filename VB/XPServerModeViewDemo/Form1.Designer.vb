Namespace XPServerModeViewDemo
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.xpServerModeView1 = New DevExpress.Xpo.XPServerModeView(Me.components)
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotalPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTax = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.xpInstantFeedbackView1 = New DevExpress.Xpo.XPInstantFeedbackView(Me.components)
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xpServerModeView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage2.SuspendLayout()
            CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'xtraTabControl1
            '
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.Size = New System.Drawing.Size(955, 601)
            Me.xtraTabControl1.TabIndex = 0
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1, Me.xtraTabPage2})
            '
            'xtraTabPage1
            '
            Me.xtraTabPage1.Controls.Add(Me.gridControl1)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(953, 572)
            Me.xtraTabPage1.Text = "XPServerModeView"
            '
            'gridControl1
            '
            Me.gridControl1.DataSource = Me.xpServerModeView1
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(953, 572)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'xpServerModeView1
            '
            Me.xpServerModeView1.ObjectType = GetType(XpoTutorial.Order)
            Me.xpServerModeView1.Properties.AddRange(New DevExpress.Xpo.ServerViewProperty() {New DevExpress.Xpo.ServerViewProperty("Oid", DevExpress.Xpo.SortDirection.Ascending, "[Oid]"), New DevExpress.Xpo.ServerViewProperty("OrderDate", DevExpress.Xpo.SortDirection.None, "[OrderDate]"), New DevExpress.Xpo.ServerViewProperty("Customer", DevExpress.Xpo.SortDirection.None, "[Customer.ContactName]"), New DevExpress.Xpo.ServerViewProperty("ProductName", DevExpress.Xpo.SortDirection.None, "[ProductName]"), New DevExpress.Xpo.ServerViewProperty("Price", DevExpress.Xpo.SortDirection.None, "[Price]"), New DevExpress.Xpo.ServerViewProperty("Quantity", DevExpress.Xpo.SortDirection.None, "[Quantity]"), New DevExpress.Xpo.ServerViewProperty("TotalPrice", DevExpress.Xpo.SortDirection.None, "[Quantity] * [Price]"), New DevExpress.Xpo.ServerViewProperty("Tax", DevExpress.Xpo.SortDirection.None, "[Quantity] * [Price] * 0.13")})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colOrderDate, Me.colCustomer, Me.colProductName, Me.colPrice, Me.colQuantity, Me.colTotalPrice, Me.colTax})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", Nothing, "(Total Price: SUM={0:0.##})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Oid", Nothing, "(Count={0})")})
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.ShowFooter = True
            '
            'colOid
            '
            Me.colOid.FieldName = "Oid"
            Me.colOid.Name = "colOid"
            Me.colOid.Visible = True
            Me.colOid.VisibleIndex = 0
            '
            'colOrderDate
            '
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.Name = "colOrderDate"
            Me.colOrderDate.Visible = True
            Me.colOrderDate.VisibleIndex = 1
            '
            'colCustomer
            '
            Me.colCustomer.FieldName = "Customer"
            Me.colCustomer.Name = "colCustomer"
            Me.colCustomer.Visible = True
            Me.colCustomer.VisibleIndex = 2
            '
            'colProductName
            '
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 3
            '
            'colPrice
            '
            Me.colPrice.FieldName = "Price"
            Me.colPrice.Name = "colPrice"
            Me.colPrice.Visible = True
            Me.colPrice.VisibleIndex = 4
            '
            'colQuantity
            '
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.Visible = True
            Me.colQuantity.VisibleIndex = 5
            '
            'colTotalPrice
            '
            Me.colTotalPrice.FieldName = "TotalPrice"
            Me.colTotalPrice.Name = "colTotalPrice"
            Me.colTotalPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "SUM={0:0.##}")})
            Me.colTotalPrice.Visible = True
            Me.colTotalPrice.VisibleIndex = 6
            '
            'colTax
            '
            Me.colTax.Caption = "Tax"
            Me.colTax.DisplayFormat.FormatString = "F3"
            Me.colTax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTax.FieldName = "Tax"
            Me.colTax.Name = "colTax"
            Me.colTax.Visible = True
            Me.colTax.VisibleIndex = 7
            '
            'xtraTabPage2
            '
            Me.xtraTabPage2.Controls.Add(Me.gridControl2)
            Me.xtraTabPage2.Name = "xtraTabPage2"
            Me.xtraTabPage2.Size = New System.Drawing.Size(953, 572)
            Me.xtraTabPage2.Text = "XPInstantFeedbackView"
            '
            'gridControl2
            '
            Me.gridControl2.DataSource = Me.xpInstantFeedbackView1
            Me.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl2.Location = New System.Drawing.Point(0, 0)
            Me.gridControl2.MainView = Me.gridView2
            Me.gridControl2.Name = "gridControl2"
            Me.gridControl2.Size = New System.Drawing.Size(953, 572)
            Me.gridControl2.TabIndex = 1
            Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView2})
            '
            'xpInstantFeedbackView1
            '
            Me.xpInstantFeedbackView1.ObjectType = GetType(XpoTutorial.Order)
            Me.xpInstantFeedbackView1.Properties.AddRange(New DevExpress.Xpo.ServerViewProperty() {New DevExpress.Xpo.ServerViewProperty("Oid", DevExpress.Xpo.SortDirection.Ascending, "[Oid]"), New DevExpress.Xpo.ServerViewProperty("OrderDate", DevExpress.Xpo.SortDirection.None, "[OrderDate]"), New DevExpress.Xpo.ServerViewProperty("Customer", DevExpress.Xpo.SortDirection.None, "[Customer.ContactName]"), New DevExpress.Xpo.ServerViewProperty("ProductName", DevExpress.Xpo.SortDirection.None, "[ProductName]"), New DevExpress.Xpo.ServerViewProperty("Price", DevExpress.Xpo.SortDirection.None, "[Price]"), New DevExpress.Xpo.ServerViewProperty("Quantity", DevExpress.Xpo.SortDirection.None, "[Quantity]"), New DevExpress.Xpo.ServerViewProperty("TotalPrice", DevExpress.Xpo.SortDirection.None, "[Quantity] * [Price]"), New DevExpress.Xpo.ServerViewProperty("Tax", DevExpress.Xpo.SortDirection.None, "[Quantity] * [Price] * 0.13")})
            '
            'gridView2
            '
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6, Me.gridColumn7, Me.gridColumn8})
            Me.gridView2.GridControl = Me.gridControl2
            Me.gridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", Nothing, "(Total Price: SUM={0:0.##})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Oid", Nothing, "(Count={0})")})
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsView.ShowFooter = True
            '
            'gridColumn1
            '
            Me.gridColumn1.FieldName = "Oid"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            '
            'gridColumn2
            '
            Me.gridColumn2.FieldName = "OrderDate"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            '
            'gridColumn3
            '
            Me.gridColumn3.FieldName = "Customer"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 2
            '
            'gridColumn4
            '
            Me.gridColumn4.FieldName = "ProductName"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.Visible = True
            Me.gridColumn4.VisibleIndex = 3
            '
            'gridColumn5
            '
            Me.gridColumn5.FieldName = "Price"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.Visible = True
            Me.gridColumn5.VisibleIndex = 4
            '
            'gridColumn6
            '
            Me.gridColumn6.FieldName = "Quantity"
            Me.gridColumn6.Name = "gridColumn6"
            Me.gridColumn6.Visible = True
            Me.gridColumn6.VisibleIndex = 5
            '
            'gridColumn7
            '
            Me.gridColumn7.FieldName = "TotalPrice"
            Me.gridColumn7.Name = "gridColumn7"
            Me.gridColumn7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "SUM={0:0.##}")})
            Me.gridColumn7.Visible = True
            Me.gridColumn7.VisibleIndex = 6
            '
            'gridColumn8
            '
            Me.gridColumn8.Caption = "Tax"
            Me.gridColumn8.DisplayFormat.FormatString = "F3"
            Me.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn8.FieldName = "Tax"
            Me.gridColumn8.Name = "gridColumn8"
            Me.gridColumn8.Visible = True
            Me.gridColumn8.VisibleIndex = 7
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(955, 601)
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Form1"
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xpServerModeView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage2.ResumeLayout(False)
            CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private xpInstantFeedbackView1 As DevExpress.Xpo.XPInstantFeedbackView
		Private xpServerModeView1 As DevExpress.Xpo.XPServerModeView
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colOid As DevExpress.XtraGrid.Columns.GridColumn
		Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colCustomer As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
		Private colPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colQuantity As DevExpress.XtraGrid.Columns.GridColumn
		Private colTotalPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colTax As DevExpress.XtraGrid.Columns.GridColumn
		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

