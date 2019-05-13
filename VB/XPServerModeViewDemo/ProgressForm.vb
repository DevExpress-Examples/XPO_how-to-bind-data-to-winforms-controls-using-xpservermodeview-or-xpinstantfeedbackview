Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace XPServerModeViewDemo
	Partial Public Class ProgressForm
		Inherits DevExpress.XtraEditors.XtraForm
		Implements IProgress(Of Integer)

		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub Report(ByVal value As Integer) Implements IProgress(Of Integer).Report
			progressBarControl1.EditValue = value
		End Sub
	End Class
End Namespace