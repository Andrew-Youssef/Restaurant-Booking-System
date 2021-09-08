<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmtables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtables))
        Me.lbltablestitle = New System.Windows.Forms.Label()
        Me.lblpeopleinstructions = New System.Windows.Forms.Label()
        Me.nudpeople = New System.Windows.Forms.NumericUpDown()
        Me.lbltableinstructions = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnpeoplesubmit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictable5 = New System.Windows.Forms.PictureBox()
        Me.pictable6 = New System.Windows.Forms.PictureBox()
        Me.pictable7 = New System.Windows.Forms.PictureBox()
        Me.pictable9 = New System.Windows.Forms.PictureBox()
        Me.pictable3 = New System.Windows.Forms.PictureBox()
        Me.pictable1 = New System.Windows.Forms.PictureBox()
        Me.pictable8 = New System.Windows.Forms.PictureBox()
        Me.pictable4 = New System.Windows.Forms.PictureBox()
        Me.pictable2 = New System.Windows.Forms.PictureBox()
        CType(Me.nudpeople, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictable7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictable9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictable8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltablestitle
        '
        Me.lbltablestitle.AutoSize = True
        Me.lbltablestitle.Font = New System.Drawing.Font("MV Boli", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltablestitle.Location = New System.Drawing.Point(266, 9)
        Me.lbltablestitle.Name = "lbltablestitle"
        Me.lbltablestitle.Size = New System.Drawing.Size(90, 34)
        Me.lbltablestitle.TabIndex = 0
        Me.lbltablestitle.Text = "Tables"
        '
        'lblpeopleinstructions
        '
        Me.lblpeopleinstructions.AutoSize = True
        Me.lblpeopleinstructions.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpeopleinstructions.Location = New System.Drawing.Point(68, 71)
        Me.lblpeopleinstructions.Name = "lblpeopleinstructions"
        Me.lblpeopleinstructions.Size = New System.Drawing.Size(586, 25)
        Me.lblpeopleinstructions.TabIndex = 1
        Me.lblpeopleinstructions.Text = "Please enter the amount of people (maximum no. of 8 people)"
        '
        'nudpeople
        '
        Me.nudpeople.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudpeople.Location = New System.Drawing.Point(299, 99)
        Me.nudpeople.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.nudpeople.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudpeople.Name = "nudpeople"
        Me.nudpeople.Size = New System.Drawing.Size(37, 33)
        Me.nudpeople.TabIndex = 2
        Me.nudpeople.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbltableinstructions
        '
        Me.lbltableinstructions.AutoSize = True
        Me.lbltableinstructions.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltableinstructions.Location = New System.Drawing.Point(161, 135)
        Me.lbltableinstructions.Name = "lbltableinstructions"
        Me.lbltableinstructions.Size = New System.Drawing.Size(409, 25)
        Me.lbltableinstructions.TabIndex = 3
        Me.lbltableinstructions.Text = "Please Double Click On Your Preferred Table"
        Me.lbltableinstructions.Visible = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.DarkRed
        Me.btnclose.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(698, 403)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(77, 35)
        Me.btnclose.TabIndex = 9
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btnpeoplesubmit
        '
        Me.btnpeoplesubmit.BackColor = System.Drawing.Color.Teal
        Me.btnpeoplesubmit.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpeoplesubmit.ForeColor = System.Drawing.Color.White
        Me.btnpeoplesubmit.Location = New System.Drawing.Point(390, 100)
        Me.btnpeoplesubmit.Name = "btnpeoplesubmit"
        Me.btnpeoplesubmit.Size = New System.Drawing.Size(75, 32)
        Me.btnpeoplesubmit.TabIndex = 24
        Me.btnpeoplesubmit.Text = "Submit"
        Me.btnpeoplesubmit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Restaurant_Booking_System_Andrew_Youssef.My.Resources.Resources.Restaurant_Logo__Small_1
        Me.PictureBox1.Location = New System.Drawing.Point(629, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 44)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'pictable5
        '
        Me.pictable5.Image = Global.Restaurant_Booking_System_Andrew_Youssef.My.Resources.Resources.Table_Type_1__unchecked____IST_200HR_Task_1_20191
        Me.pictable5.Location = New System.Drawing.Point(73, 325)
        Me.pictable5.Name = "pictable5"
        Me.pictable5.Size = New System.Drawing.Size(50, 113)
        Me.pictable5.TabIndex = 22
        Me.pictable5.TabStop = False
        '
        'pictable6
        '
        Me.pictable6.Image = Global.Restaurant_Booking_System_Andrew_Youssef.My.Resources.Resources.Table_Type_2__unchecked____IST_200HR_Task_1_2019
        Me.pictable6.Location = New System.Drawing.Point(166, 325)
        Me.pictable6.Name = "pictable6"
        Me.pictable6.Size = New System.Drawing.Size(100, 113)
        Me.pictable6.TabIndex = 20
        Me.pictable6.TabStop = False
        '
        'pictable7
        '
        Me.pictable7.Image = Global.Restaurant_Booking_System_Andrew_Youssef.My.Resources.Resources.Table_Type_2__unchecked____IST_200HR_Task_1_2019
        Me.pictable7.Location = New System.Drawing.Point(272, 325)
        Me.pictable7.Name = "pictable7"
        Me.pictable7.Size = New System.Drawing.Size(100, 113)
        Me.pictable7.TabIndex = 18
        Me.pictable7.TabStop = False
        '
        'pictable9
        '
        Me.pictable9.Image = Global.Restaurant_Booking_System_Andrew_Youssef.My.Resources.Resources.Table_Type_2__unchecked____IST_200HR_Task_1_2019
        Me.pictable9.Location = New System.Drawing.Point(484, 325)
        Me.pictable9.Name = "pictable9"
        Me.pictable9.Size = New System.Drawing.Size(100, 113)
        Me.pictable9.TabIndex = 16
        Me.pictable9.TabStop = False
        '
        'pictable3
        '
        Me.pictable3.Image = Global.Restaurant_Booking_System_Andrew_Youssef.My.Resources.Resources.Table_Type_3__unchecked____IST_200HR_Task_1_2019
        Me.pictable3.Location = New System.Drawing.Point(194, 206)
        Me.pictable3.Name = "pictable3"
        Me.pictable3.Size = New System.Drawing.Size(200, 113)
        Me.pictable3.TabIndex = 14
        Me.pictable3.TabStop = False
        '
        'pictable1
        '
        Me.pictable1.Image = Global.Restaurant_Booking_System_Andrew_Youssef.My.Resources.Resources.Table_Type_1__unchecked____IST_200HR_Task_1_20191
        Me.pictable1.Location = New System.Drawing.Point(73, 206)
        Me.pictable1.Name = "pictable1"
        Me.pictable1.Size = New System.Drawing.Size(50, 113)
        Me.pictable1.TabIndex = 12
        Me.pictable1.TabStop = False
        '
        'pictable8
        '
        Me.pictable8.Image = Global.Restaurant_Booking_System_Andrew_Youssef.My.Resources.Resources.Table_Type_2__unchecked____IST_200HR_Task_1_2019
        Me.pictable8.Location = New System.Drawing.Point(378, 325)
        Me.pictable8.Name = "pictable8"
        Me.pictable8.Size = New System.Drawing.Size(100, 113)
        Me.pictable8.TabIndex = 7
        Me.pictable8.TabStop = False
        '
        'pictable4
        '
        Me.pictable4.Image = Global.Restaurant_Booking_System_Andrew_Youssef.My.Resources.Resources.Table_Type_3__unchecked____IST_200HR_Task_1_2019
        Me.pictable4.Location = New System.Drawing.Point(400, 206)
        Me.pictable4.Name = "pictable4"
        Me.pictable4.Size = New System.Drawing.Size(200, 113)
        Me.pictable4.TabIndex = 5
        Me.pictable4.TabStop = False
        '
        'pictable2
        '
        Me.pictable2.Image = Global.Restaurant_Booking_System_Andrew_Youssef.My.Resources.Resources.Table_Type_1__unchecked____IST_200HR_Task_1_20191
        Me.pictable2.Location = New System.Drawing.Point(138, 206)
        Me.pictable2.Name = "pictable2"
        Me.pictable2.Size = New System.Drawing.Size(50, 113)
        Me.pictable2.TabIndex = 4
        Me.pictable2.TabStop = False
        '
        'frmtables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(787, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnpeoplesubmit)
        Me.Controls.Add(Me.pictable5)
        Me.Controls.Add(Me.pictable6)
        Me.Controls.Add(Me.pictable7)
        Me.Controls.Add(Me.pictable9)
        Me.Controls.Add(Me.pictable3)
        Me.Controls.Add(Me.pictable1)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.pictable8)
        Me.Controls.Add(Me.pictable4)
        Me.Controls.Add(Me.pictable2)
        Me.Controls.Add(Me.lbltableinstructions)
        Me.Controls.Add(Me.nudpeople)
        Me.Controls.Add(Me.lblpeopleinstructions)
        Me.Controls.Add(Me.lbltablestitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmtables"
        Me.Text = "Tables"
        CType(Me.nudpeople, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictable7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictable9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictable8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltablestitle As Label
    Friend WithEvents lblpeopleinstructions As Label
    Friend WithEvents nudpeople As NumericUpDown
    Friend WithEvents lbltableinstructions As Label
    Friend WithEvents pictable2 As PictureBox
    Friend WithEvents pictable4 As PictureBox
    Friend WithEvents pictable8 As PictureBox
    Friend WithEvents btnclose As Button
    Friend WithEvents pictable1 As PictureBox
    Friend WithEvents pictable3 As PictureBox
    Friend WithEvents pictable9 As PictureBox
    Friend WithEvents pictable7 As PictureBox
    Friend WithEvents pictable6 As PictureBox
    Friend WithEvents pictable5 As PictureBox
    Friend WithEvents btnpeoplesubmit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
