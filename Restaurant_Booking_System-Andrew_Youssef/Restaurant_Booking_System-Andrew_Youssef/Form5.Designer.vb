<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmthankyou
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmthankyou))
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lblthankyou = New System.Windows.Forms.Label()
        Me.piclogo = New System.Windows.Forms.PictureBox()
        Me.lbldetails = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.DarkRed
        Me.btnclose.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(643, 403)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(77, 35)
        Me.btnclose.TabIndex = 10
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'lblthankyou
        '
        Me.lblthankyou.AutoSize = True
        Me.lblthankyou.Font = New System.Drawing.Font("MV Boli", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblthankyou.Location = New System.Drawing.Point(94, 35)
        Me.lblthankyou.Name = "lblthankyou"
        Me.lblthankyou.Size = New System.Drawing.Size(394, 39)
        Me.lblthankyou.TabIndex = 13
        Me.lblthankyou.Text = "Thank You  For Booking At"
        '
        'piclogo
        '
        Me.piclogo.Image = Global.Restaurant_Booking_System_Andrew_Youssef.My.Resources.Resources.Restaurant_Logo4
        Me.piclogo.Location = New System.Drawing.Point(136, 100)
        Me.piclogo.Name = "piclogo"
        Me.piclogo.Size = New System.Drawing.Size(450, 240)
        Me.piclogo.TabIndex = 12
        Me.piclogo.TabStop = False
        '
        'lbldetails
        '
        Me.lbldetails.AutoSize = True
        Me.lbldetails.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldetails.Location = New System.Drawing.Point(88, 365)
        Me.lbldetails.Name = "lbldetails"
        Me.lbldetails.Size = New System.Drawing.Size(523, 25)
        Me.lbldetails.TabIndex = 14
        Me.lbldetails.Text = "For Booking Enquiries Please Contact: (02) 7499 3742"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(463, 31)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "We Look Forward To Seeing You Soon!"
        '
        'frmthankyou
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(732, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbldetails)
        Me.Controls.Add(Me.lblthankyou)
        Me.Controls.Add(Me.piclogo)
        Me.Controls.Add(Me.btnclose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmthankyou"
        Me.Text = "Thank You!"
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnclose As Button
    Friend WithEvents piclogo As PictureBox
    Friend WithEvents lblthankyou As Label
    Friend WithEvents lbldetails As Label
    Friend WithEvents Label1 As Label
End Class
