Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.UserSkins
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports XpoTutorial
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors

Namespace XPServerModeViewDemo
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			BonusSkins.Register()
			Try
				ConnectionHelper.Connect()
				GenerateTestData()
			Catch ex As Exception
				XtraMessageBox.Show(ex.Message)
				Return
			End Try
			Application.Run(New Form1())
		End Sub

		Private Sub GenerateTestData()
			Using uow As New UnitOfWork()
				If DemoDataHelper.IsSeedRequired(uow) Then
					Using progressForm As New ProgressForm()
						AddHandler progressForm.Shown, Async Sub(s, args)
							Await DemoDataHelper.SeedAsync(uow, progressForm)
							progressForm.Close()
						End Sub
						progressForm.ShowDialog()
					End Using
				End If
			End Using
		End Sub
	End Module
End Namespace
