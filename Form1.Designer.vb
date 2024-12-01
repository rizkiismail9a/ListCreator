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
        Label1 = New Label()
        inputText = New TextBox()
        inputAmount = New TextBox()
        Label2 = New Label()
        processBtn = New Button()
        ListBox = New ListBox()
        clearBtn = New Button()
        exitBtn = New Button()
        warning = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(56, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 32)
        Label1.TabIndex = 0
        Label1.Text = "Tulis Teks"
        ' 
        ' inputText
        ' 
        inputText.Location = New Point(191, 40)
        inputText.Name = "inputText"
        inputText.Size = New Size(335, 39)
        inputText.TabIndex = 1
        ' 
        ' inputAmount
        ' 
        inputAmount.Location = New Point(300, 131)
        inputAmount.Name = "inputAmount"
        inputAmount.Size = New Size(226, 39)
        inputAmount.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(56, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(216, 32)
        Label2.TabIndex = 2
        Label2.Text = "Jumlah Perulangan"
        ' 
        ' processBtn
        ' 
        processBtn.Location = New Point(155, 201)
        processBtn.Name = "processBtn"
        processBtn.Size = New Size(246, 51)
        processBtn.TabIndex = 4
        processBtn.Text = "Proses"
        processBtn.UseVisualStyleBackColor = True
        ' 
        ' ListBox
        ' 
        ListBox.FormattingEnabled = True
        ListBox.Location = New Point(56, 284)
        ListBox.Name = "ListBox"
        ListBox.Size = New Size(470, 164)
        ListBox.TabIndex = 5
        ' 
        ' clearBtn
        ' 
        clearBtn.Location = New Point(56, 498)
        clearBtn.Name = "clearBtn"
        clearBtn.Size = New Size(182, 51)
        clearBtn.TabIndex = 6
        clearBtn.Text = "Clear"
        clearBtn.UseVisualStyleBackColor = True
        ' 
        ' exitBtn
        ' 
        exitBtn.Location = New Point(344, 498)
        exitBtn.Name = "exitBtn"
        exitBtn.Size = New Size(182, 51)
        exitBtn.TabIndex = 7
        exitBtn.Text = "Keluar"
        exitBtn.UseVisualStyleBackColor = True
        ' 
        ' warning
        ' 
        warning.AutoSize = True
        warning.Font = New Font("Segoe UI", 6F)
        warning.ForeColor = Color.Red
        warning.Location = New Point(428, 173)
        warning.Name = "warning"
        warning.Size = New Size(98, 21)
        warning.TabIndex = 8
        warning.Text = "hanya angka"
        warning.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(582, 580)
        Controls.Add(warning)
        Controls.Add(exitBtn)
        Controls.Add(clearBtn)
        Controls.Add(ListBox)
        Controls.Add(processBtn)
        Controls.Add(inputAmount)
        Controls.Add(Label2)
        Controls.Add(inputText)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Buat Perulangan Teks"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents inputText As TextBox
    Friend WithEvents inputAmount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents processBtn As Button
    Friend WithEvents ListBox As ListBox
    Friend WithEvents clearBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents warning As Label

End Class
