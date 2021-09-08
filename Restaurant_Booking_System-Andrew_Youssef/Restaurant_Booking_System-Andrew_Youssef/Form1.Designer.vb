<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmwelcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmwelcome))
        Me.lblwelcometitle = New System.Windows.Forms.Label()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.piclogo = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblwelcometitle
        '
        Me.lblwelcometitle.AutoSize = True
        Me.lblwelcometitle.Font = New System.Drawing.Font("MV Boli", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcometitle.Location = New System.Drawing.Point(300, 9)
        Me.lblwelcometitle.Name = "lblwelcometitle"
        Me.lblwelcometitle.Size = New System.Drawing.Size(186, 39)
        Me.lblwelcometitle.TabIndex = 0
        Me.lblwelcometitle.Text = "Welcome to:"
        '
        'btnstart
        '
        Me.btnstart.BackColor = System.Drawing.Color.Teal
        Me.btnstart.Font = New System.Drawing.Font("MV Boli", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstart.ForeColor = System.Drawing.Color.White
        Me.btnstart.Location = New System.Drawing.Point(318, 343)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(151, 75)
        Me.btnstart.TabIndex = 2
        Me.btnstart.Text = "Submit"
        Me.btnstart.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.DarkRed
        Me.btnclose.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(643, 403)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(77, 35)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(337, 301)
        Me.txtusername.MaxLength = 10
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(122, 33)
        Me.txtusername.TabIndex = 5
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("MV Boli", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(233, 299)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(75, 28)
        Me.lblusername.TabIndex = 6
        Me.lblusername.Text = "Name:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Restaurant_Booking_System_Andrew_Youssef.My.Resources.Resources.Meat_Lover_s_Pizza1
        Me.PictureBox2.Location = New System.Drawing.Point(12, 70)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Restaurant_Booking_System_Andrew_Youssef.My.Resources.Resources.Vegetarian_Pizza1
        Me.PictureBox1.Location = New System.Drawing.Point(575, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'piclogo
        '
        Me.piclogo.Image = Global.Restaurant_Booking_System_Andrew_Youssef.My.Resources.Resources.Restaurant_Logo3
        Me.piclogo.Location = New System.Drawing.Point(166, 51)
        Me.piclogo.Name = "piclogo"
        Me.piclogo.Size = New System.Drawing.Size(450, 240)
        Me.piclogo.TabIndex = 4
        Me.piclogo.TabStop = False
        '
        'frmwelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(787, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.piclogo)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.lblwelcometitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmwelcome"
        Me.Text = "Welcome to Andrew's Pizzeria"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblwelcometitle As Label
    Friend WithEvents btnstart As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents piclogo As PictureBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents lblusername As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
