Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Namespace ShowEditorOnEnter
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
		Friend GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Friend colColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Friend colColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Friend colColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Friend TextEdit1 As DevExpress.XtraEditors.TextEdit
		Friend DataSet1 As System.Data.DataSet
		Friend DataTable1 As System.Data.DataTable
		Friend DataColumn1 As System.Data.DataColumn
		Friend DataColumn2 As System.Data.DataColumn
		Friend DataColumn3 As System.Data.DataColumn
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.DataSet1 = New System.Data.DataSet()
			Me.DataTable1 = New System.Data.DataTable()
			Me.DataColumn1 = New System.Data.DataColumn()
			Me.DataColumn2 = New System.Data.DataColumn()
			Me.DataColumn3 = New System.Data.DataColumn()
			CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' GridControl1
			' 
			Me.GridControl1.DataSource = Me.DataTable1
			' 
			' GridControl1.EmbeddedNavigator
			' 
			Me.GridControl1.EmbeddedNavigator.Name = ""
			Me.GridControl1.Location = New System.Drawing.Point(8, 40)
			Me.GridControl1.MainView = Me.GridView1
			Me.GridControl1.Name = "GridControl1"
			Me.GridControl1.TabIndex = 3
			Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.GridView1})
'			Me.GridControl1.Enter += New System.EventHandler(Me.GridControl1_Enter);
			' 
			' GridView1
			' 
			Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colColumn1, Me.colColumn2, Me.colColumn3})
			Me.GridView1.GridControl = Me.GridControl1
			Me.GridView1.Name = "GridView1"
			Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
			' 
			' colColumn1
			' 
			Me.colColumn1.Caption = "Column1"
			Me.colColumn1.FieldName = "Column1"
			Me.colColumn1.Name = "colColumn1"
			Me.colColumn1.Visible = True
			Me.colColumn1.VisibleIndex = 0
			' 
			' colColumn2
			' 
			Me.colColumn2.Caption = "Column2"
			Me.colColumn2.FieldName = "Column2"
			Me.colColumn2.Name = "colColumn2"
			Me.colColumn2.Visible = True
			Me.colColumn2.VisibleIndex = 1
			' 
			' colColumn3
			' 
			Me.colColumn3.Caption = "Column3"
			Me.colColumn3.FieldName = "Column3"
			Me.colColumn3.Name = "colColumn3"
			Me.colColumn3.Visible = True
			Me.colColumn3.VisibleIndex = 2
			' 
			' TextEdit1
			' 
			Me.TextEdit1.EditValue = "Press Tab to focus the grid and start editing"
			Me.TextEdit1.Location = New System.Drawing.Point(8, 8)
			Me.TextEdit1.Name = "TextEdit1"
			' 
			' TextEdit1.Properties
			' 
			Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
			Me.TextEdit1.Size = New System.Drawing.Size(400, 20)
			Me.TextEdit1.TabIndex = 2
			' 
			' DataSet1
			' 
			Me.DataSet1.DataSetName = "NewDataSet"
			Me.DataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.DataSet1.Tables.AddRange(New System.Data.DataTable() { Me.DataTable1})
			' 
			' DataTable1
			' 
			Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.DataColumn1, Me.DataColumn2, Me.DataColumn3})
			Me.DataTable1.TableName = "Table1"
			' 
			' DataColumn1
			' 
			Me.DataColumn1.ColumnName = "Column1"
			' 
			' DataColumn2
			' 
			Me.DataColumn2.ColumnName = "Column2"
			' 
			' DataColumn3
			' 
			Me.DataColumn3.ColumnName = "Column3"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(416, 250)
			Me.Controls.Add(Me.GridControl1)
			Me.Controls.Add(Me.TextEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
        End Sub
        Dim view As GridView

        Private Sub ShowEditor()
            view.ShowEditor()
        End Sub

        Private Sub GridControl1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Enter
            Dim grid As GridControl = TryCast(sender, GridControl)
            view = TryCast(grid.MainView, GridView)

            If view.DataRowCount = 0 Then
                If view.FocusedRowHandle = GridControl.InvalidRowHandle Then
                    view.FocusedRowHandle = GridControl.NewItemRowHandle
                End If
                BeginInvoke(New MethodInvoker(AddressOf ShowEditor))
            End If
        End Sub
    End Class
End Namespace
