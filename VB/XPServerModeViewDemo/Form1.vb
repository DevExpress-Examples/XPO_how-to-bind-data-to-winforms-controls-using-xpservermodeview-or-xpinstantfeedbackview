Imports DevExpress.Xpo
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports XpoTutorial

Namespace XPServerModeViewDemo
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Private ReadOnly session As Session

		Public Sub New()
			InitializeComponent()
			session = New Session(XpoDefault.DataLayer)
			AddHandler xpServerModeView1.ResolveSession, Sub(s, e)
				e.Session = session
			End Sub
			AddHandler xpInstantFeedbackView1.ResolveSession, Sub(s, e)
				e.Session = session
			End Sub
		End Sub
	End Class
End Namespace
