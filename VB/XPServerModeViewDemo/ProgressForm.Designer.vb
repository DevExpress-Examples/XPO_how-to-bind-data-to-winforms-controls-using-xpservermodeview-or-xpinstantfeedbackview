Namespace XPServerModeViewDemo
	Partial Public Class ProgressForm
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
			Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' progressBarControl1
			' 
			Me.progressBarControl1.Location = New System.Drawing.Point(12, 12)
			Me.progressBarControl1.Name = "progressBarControl1"
			Me.progressBarControl1.Size = New System.Drawing.Size(339, 18)
			Me.progressBarControl1.TabIndex = 0
			' 
			' ProgressForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(363, 45)
			Me.Controls.Add(Me.progressBarControl1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "ProgressForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Sample Data Generation..."
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
	End Class
End Namespace