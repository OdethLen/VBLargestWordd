<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lblLargestWord = New Label()
        txtDocument = New TextBox()
        btnOpen = New Button()
        SuspendLayout()
        ' 
        ' lblLargestWord
        ' 
        lblLargestWord.AutoSize = True
        lblLargestWord.Location = New Point(243, 227)
        lblLargestWord.Name = "lblLargestWord"
        lblLargestWord.Size = New Size(16, 15)
        lblLargestWord.TabIndex = 5
        lblLargestWord.Text = "..."
        ' 
        ' txtDocument
        ' 
        txtDocument.Location = New Point(112, 67)
        txtDocument.Multiline = True
        txtDocument.Name = "txtDocument"
        txtDocument.ReadOnly = True
        txtDocument.ScrollBars = ScrollBars.Vertical
        txtDocument.Size = New Size(300, 139)
        txtDocument.TabIndex = 4
        ' 
        ' btnOpen
        ' 
        btnOpen.Location = New Point(217, 25)
        btnOpen.Name = "btnOpen"
        btnOpen.Size = New Size(75, 23)
        btnOpen.TabIndex = 3
        btnOpen.Text = "Open"
        btnOpen.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(555, 263)
        Controls.Add(lblLargestWord)
        Controls.Add(txtDocument)
        Controls.Add(btnOpen)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLargestWord As Label
    Friend WithEvents txtDocument As TextBox
    Friend WithEvents btnOpen As Button

End Class
