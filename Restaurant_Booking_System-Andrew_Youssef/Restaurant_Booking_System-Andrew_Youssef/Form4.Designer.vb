<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmconfirmation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmconfirmation))
        Me.lblconfirmationtitle = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lblpeopledisplay = New System.Windows.Forms.Label()
        Me.lblentreedisplay = New System.Windows.Forms.Label()
        Me.lblmaindisplay = New System.Windows.Forms.Label()
        Me.lbldessertdisplay = New System.Windows.Forms.Label()
        Me.lbldrinkdisplay = New System.Windows.Forms.Label()
        Me.lblpeople = New System.Windows.Forms.Label()
        Me.lblentree = New System.Windows.Forms.Label()
        Me.lblmain = New System.Windows.Forms.Label()
        Me.lbldessert = New System.Windows.Forms.Label()
        Me.lbldrink = New System.Windows.Forms.Label()
        Me.lbltabledisplay = New System.Windows.Forms.Label()
        Me.lbltable = New System.Windows.Forms.Label()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.lblremoval = New System.Windows.Forms.Label()
        Me.lblextra = New System.Windows.Forms.Label()
        Me.lblremovaldisplay = New System.Windows.Forms.Label()
        Me.lblextradisplay = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lbltotaldisplay = New System.Windows.Forms.Label()
        Me.lbldollarsign8 = New System.Windows.Forms.Label()
        Me.lbldollarsign6 = New System.Windows.Forms.Label()
        Me.lbldollarsign5 = New System.Windows.Forms.Label()
        Me.lbldollarsign4 = New System.Windows.Forms.Label()
        Me.lbldollarsign3 = New System.Windows.Forms.Label()
        Me.lbldollarsign2 = New System.Windows.Forms.Label()
        Me.lbldollarsign1 = New System.Windows.Forms.Label()
        Me.lbltablelayout = New System.Windows.Forms.Label()
        Me.lbldollarsign7 = New System.Windows.Forms.Label()
        Me.lblgst = New System.Windows.Forms.Label()
        Me.lblgstdisplay = New System.Windows.Forms.Label()
        Me.btnbacktoorders = New System.Windows.Forms.Button()
        Me.btnbacktotables = New System.Windows.Forms.Button()
        Me.pictablelayout = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pictablelayout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblconfirmationtitle
        '
        Me.lblconfirmationtitle.AutoSize = True
        Me.lblconfirmationtitle.Font = New System.Drawing.Font("MV Boli", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfirmationtitle.Location = New System.Drawing.Point(253, 24)
        Me.lblconfirmationtitle.Name = "lblconfirmationtitle"
        Me.lblconfirmationtitle.Size = New System.Drawing.Size(188, 34)
        Me.lblconfirmationtitle.TabIndex = 0
        Me.lblconfirmationtitle.Text = "Confirmation"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.DarkRed
        Me.btnclose.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(643, 403)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(77, 35)
        Me.btnclose.TabIndex = 4
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'lblpeopledisplay
        '
        Me.lblpeopledisplay.AutoSize = True
        Me.lblpeopledisplay.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpeopledisplay.Location = New System.Drawing.Point(214, 69)
        Me.lblpeopledisplay.Name = "lblpeopledisplay"
        Me.lblpeopledisplay.Size = New System.Drawing.Size(153, 21)
        Me.lblpeopledisplay.TabIndex = 5
        Me.lblpeopledisplay.Text = "Amount of People:"
        '
        'lblentreedisplay
        '
        Me.lblentreedisplay.AutoSize = True
        Me.lblentreedisplay.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblentreedisplay.Location = New System.Drawing.Point(67, 124)
        Me.lblentreedisplay.Name = "lblentreedisplay"
        Me.lblentreedisplay.Size = New System.Drawing.Size(73, 21)
        Me.lblentreedisplay.TabIndex = 6
        Me.lblentreedisplay.Text = "Entrees:"
        '
        'lblmaindisplay
        '
        Me.lblmaindisplay.AutoSize = True
        Me.lblmaindisplay.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmaindisplay.Location = New System.Drawing.Point(67, 151)
        Me.lblmaindisplay.Name = "lblmaindisplay"
        Me.lblmaindisplay.Size = New System.Drawing.Size(59, 21)
        Me.lblmaindisplay.TabIndex = 7
        Me.lblmaindisplay.Text = "Mains:"
        '
        'lbldessertdisplay
        '
        Me.lbldessertdisplay.AutoSize = True
        Me.lbldessertdisplay.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldessertdisplay.Location = New System.Drawing.Point(67, 180)
        Me.lbldessertdisplay.Name = "lbldessertdisplay"
        Me.lbldessertdisplay.Size = New System.Drawing.Size(79, 21)
        Me.lbldessertdisplay.TabIndex = 8
        Me.lbldessertdisplay.Text = "Desserts:"
        '
        'lbldrinkdisplay
        '
        Me.lbldrinkdisplay.AutoSize = True
        Me.lbldrinkdisplay.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrinkdisplay.Location = New System.Drawing.Point(67, 211)
        Me.lbldrinkdisplay.Name = "lbldrinkdisplay"
        Me.lbldrinkdisplay.Size = New System.Drawing.Size(62, 21)
        Me.lbldrinkdisplay.TabIndex = 9
        Me.lbldrinkdisplay.Text = "Drinks:"
        '
        'lblpeople
        '
        Me.lblpeople.AutoSize = True
        Me.lblpeople.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpeople.Location = New System.Drawing.Point(412, 68)
        Me.lblpeople.Name = "lblpeople"
        Me.lblpeople.Size = New System.Drawing.Size(64, 21)
        Me.lblpeople.TabIndex = 10
        Me.lblpeople.Text = "People"
        '
        'lblentree
        '
        Me.lblentree.AutoSize = True
        Me.lblentree.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblentree.Location = New System.Drawing.Point(265, 124)
        Me.lblentree.Name = "lblentree"
        Me.lblentree.Size = New System.Drawing.Size(66, 21)
        Me.lblentree.TabIndex = 11
        Me.lblentree.Text = "Entree"
        '
        'lblmain
        '
        Me.lblmain.AutoSize = True
        Me.lblmain.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmain.Location = New System.Drawing.Point(265, 151)
        Me.lblmain.Name = "lblmain"
        Me.lblmain.Size = New System.Drawing.Size(50, 21)
        Me.lblmain.TabIndex = 12
        Me.lblmain.Text = "Main"
        '
        'lbldessert
        '
        Me.lbldessert.AutoSize = True
        Me.lbldessert.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldessert.Location = New System.Drawing.Point(265, 180)
        Me.lbldessert.Name = "lbldessert"
        Me.lbldessert.Size = New System.Drawing.Size(73, 21)
        Me.lbldessert.TabIndex = 13
        Me.lbldessert.Text = "Dessert"
        '
        'lbldrink
        '
        Me.lbldrink.AutoSize = True
        Me.lbldrink.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrink.Location = New System.Drawing.Point(265, 211)
        Me.lbldrink.Name = "lbldrink"
        Me.lbldrink.Size = New System.Drawing.Size(54, 21)
        Me.lbldrink.TabIndex = 14
        Me.lbldrink.Text = "Drink"
        '
        'lbltabledisplay
        '
        Me.lbltabledisplay.AutoSize = True
        Me.lbltabledisplay.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltabledisplay.Location = New System.Drawing.Point(214, 96)
        Me.lbltabledisplay.Name = "lbltabledisplay"
        Me.lbltabledisplay.Size = New System.Drawing.Size(55, 21)
        Me.lbltabledisplay.TabIndex = 15
        Me.lbltabledisplay.Text = "Table:"
        '
        'lbltable
        '
        Me.lbltable.AutoSize = True
        Me.lbltable.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltable.Location = New System.Drawing.Point(412, 96)
        Me.lbltable.Name = "lbltable"
        Me.lbltable.Size = New System.Drawing.Size(54, 21)
        Me.lbltable.TabIndex = 16
        Me.lbltable.Text = "Table"
        '
        'btnconfirm
        '
        Me.btnconfirm.BackColor = System.Drawing.Color.Teal
        Me.btnconfirm.Font = New System.Drawing.Font("MV Boli", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirm.ForeColor = System.Drawing.Color.White
        Me.btnconfirm.Location = New System.Drawing.Point(309, 380)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(117, 66)
        Me.btnconfirm.TabIndex = 17
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = False
        '
        'lblremoval
        '
        Me.lblremoval.AutoSize = True
        Me.lblremoval.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremoval.Location = New System.Drawing.Point(265, 270)
        Me.lblremoval.Name = "lblremoval"
        Me.lblremoval.Size = New System.Drawing.Size(78, 21)
        Me.lblremoval.TabIndex = 85
        Me.lblremoval.Text = "Removal"
        '
        'lblextra
        '
        Me.lblextra.AutoSize = True
        Me.lblextra.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblextra.Location = New System.Drawing.Point(265, 239)
        Me.lblextra.Name = "lblextra"
        Me.lblextra.Size = New System.Drawing.Size(56, 21)
        Me.lblextra.TabIndex = 84
        Me.lblextra.Text = "Extra"
        '
        'lblremovaldisplay
        '
        Me.lblremovaldisplay.AutoSize = True
        Me.lblremovaldisplay.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremovaldisplay.Location = New System.Drawing.Point(67, 270)
        Me.lblremovaldisplay.Name = "lblremovaldisplay"
        Me.lblremovaldisplay.Size = New System.Drawing.Size(84, 21)
        Me.lblremovaldisplay.TabIndex = 83
        Me.lblremovaldisplay.Text = "Removals:"
        '
        'lblextradisplay
        '
        Me.lblextradisplay.AutoSize = True
        Me.lblextradisplay.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblextradisplay.Location = New System.Drawing.Point(67, 239)
        Me.lblextradisplay.Name = "lblextradisplay"
        Me.lblextradisplay.Size = New System.Drawing.Size(64, 21)
        Me.lblextradisplay.TabIndex = 82
        Me.lblextradisplay.Text = "Extras:"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("MV Boli", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(273, 338)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(85, 34)
        Me.lbltotal.TabIndex = 87
        Me.lbltotal.Text = "Total"
        '
        'lbltotaldisplay
        '
        Me.lbltotaldisplay.AutoSize = True
        Me.lbltotaldisplay.Font = New System.Drawing.Font("MV Boli", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotaldisplay.Location = New System.Drawing.Point(67, 338)
        Me.lbltotaldisplay.Name = "lbltotaldisplay"
        Me.lbltotaldisplay.Size = New System.Drawing.Size(90, 34)
        Me.lbltotaldisplay.TabIndex = 86
        Me.lbltotaldisplay.Text = "Total:"
        '
        'lbldollarsign8
        '
        Me.lbldollarsign8.AutoSize = True
        Me.lbldollarsign8.Font = New System.Drawing.Font("MV Boli", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldollarsign8.Location = New System.Drawing.Point(247, 338)
        Me.lbldollarsign8.Name = "lbldollarsign8"
        Me.lbldollarsign8.Size = New System.Drawing.Size(31, 34)
        Me.lbldollarsign8.TabIndex = 94
        Me.lbldollarsign8.Text = "$"
        '
        'lbldollarsign6
        '
        Me.lbldollarsign6.AutoSize = True
        Me.lbldollarsign6.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldollarsign6.Location = New System.Drawing.Point(247, 270)
        Me.lbldollarsign6.Name = "lbldollarsign6"
        Me.lbldollarsign6.Size = New System.Drawing.Size(20, 21)
        Me.lbldollarsign6.TabIndex = 93
        Me.lbldollarsign6.Text = "$"
        '
        'lbldollarsign5
        '
        Me.lbldollarsign5.AutoSize = True
        Me.lbldollarsign5.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldollarsign5.Location = New System.Drawing.Point(247, 239)
        Me.lbldollarsign5.Name = "lbldollarsign5"
        Me.lbldollarsign5.Size = New System.Drawing.Size(20, 21)
        Me.lbldollarsign5.TabIndex = 92
        Me.lbldollarsign5.Text = "$"
        '
        'lbldollarsign4
        '
        Me.lbldollarsign4.AutoSize = True
        Me.lbldollarsign4.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldollarsign4.Location = New System.Drawing.Point(247, 211)
        Me.lbldollarsign4.Name = "lbldollarsign4"
        Me.lbldollarsign4.Size = New System.Drawing.Size(20, 21)
        Me.lbldollarsign4.TabIndex = 91
        Me.lbldollarsign4.Text = "$"
        '
        'lbldollarsign3
        '
        Me.lbldollarsign3.AutoSize = True
        Me.lbldollarsign3.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldollarsign3.Location = New System.Drawing.Point(247, 180)
        Me.lbldollarsign3.Name = "lbldollarsign3"
        Me.lbldollarsign3.Size = New System.Drawing.Size(20, 21)
        Me.lbldollarsign3.TabIndex = 90
        Me.lbldollarsign3.Text = "$"
        '
        'lbldollarsign2
        '
        Me.lbldollarsign2.AutoSize = True
        Me.lbldollarsign2.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldollarsign2.Location = New System.Drawing.Point(247, 151)
        Me.lbldollarsign2.Name = "lbldollarsign2"
        Me.lbldollarsign2.Size = New System.Drawing.Size(20, 21)
        Me.lbldollarsign2.TabIndex = 89
        Me.lbldollarsign2.Text = "$"
        '
        'lbldollarsign1
        '
        Me.lbldollarsign1.AutoSize = True
        Me.lbldollarsign1.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldollarsign1.Location = New System.Drawing.Point(247, 124)
        Me.lbldollarsign1.Name = "lbldollarsign1"
        Me.lbldollarsign1.Size = New System.Drawing.Size(20, 21)
        Me.lbldollarsign1.TabIndex = 88
        Me.lbldollarsign1.Text = "$"
        '
        'lbltablelayout
        '
        Me.lbltablelayout.AutoSize = True
        Me.lbltablelayout.Font = New System.Drawing.Font("MV Boli", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltablelayout.Location = New System.Drawing.Point(490, 151)
        Me.lbltablelayout.Name = "lbltablelayout"
        Me.lbltablelayout.Size = New System.Drawing.Size(151, 28)
        Me.lbltablelayout.TabIndex = 96
        Me.lbltablelayout.Text = "Table Layout"
        '
        'lbldollarsign7
        '
        Me.lbldollarsign7.AutoSize = True
        Me.lbldollarsign7.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldollarsign7.Location = New System.Drawing.Point(247, 304)
        Me.lbldollarsign7.Name = "lbldollarsign7"
        Me.lbldollarsign7.Size = New System.Drawing.Size(20, 21)
        Me.lbldollarsign7.TabIndex = 99
        Me.lbldollarsign7.Text = "$"
        '
        'lblgst
        '
        Me.lblgst.AutoSize = True
        Me.lblgst.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgst.Location = New System.Drawing.Point(265, 304)
        Me.lblgst.Name = "lblgst"
        Me.lblgst.Size = New System.Drawing.Size(44, 21)
        Me.lblgst.TabIndex = 98
        Me.lblgst.Text = "GST"
        '
        'lblgstdisplay
        '
        Me.lblgstdisplay.AutoSize = True
        Me.lblgstdisplay.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgstdisplay.Location = New System.Drawing.Point(67, 301)
        Me.lblgstdisplay.Name = "lblgstdisplay"
        Me.lblgstdisplay.Size = New System.Drawing.Size(101, 21)
        Me.lblgstdisplay.TabIndex = 97
        Me.lblgstdisplay.Text = "GST (10%):"
        '
        'btnbacktoorders
        '
        Me.btnbacktoorders.BackColor = System.Drawing.Color.Teal
        Me.btnbacktoorders.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbacktoorders.ForeColor = System.Drawing.Color.White
        Me.btnbacktoorders.Location = New System.Drawing.Point(645, 348)
        Me.btnbacktoorders.Name = "btnbacktoorders"
        Me.btnbacktoorders.Size = New System.Drawing.Size(75, 49)
        Me.btnbacktoorders.TabIndex = 112
        Me.btnbacktoorders.Text = "Back To Orders"
        Me.btnbacktoorders.UseVisualStyleBackColor = False
        '
        'btnbacktotables
        '
        Me.btnbacktotables.BackColor = System.Drawing.Color.Teal
        Me.btnbacktotables.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbacktotables.ForeColor = System.Drawing.Color.White
        Me.btnbacktotables.Location = New System.Drawing.Point(564, 348)
        Me.btnbacktotables.Name = "btnbacktotables"
        Me.btnbacktotables.Size = New System.Drawing.Size(75, 49)
        Me.btnbacktotables.TabIndex = 113
        Me.btnbacktotables.Text = "Back To Tables"
        Me.btnbacktotables.UseVisualStyleBackColor = False
        '
        'pictablelayout
        '
        Me.pictablelayout.Image = Global.Restaurant_Booking_System_Andrew_Youssef.My.Resources.Resources.Table_Layout___IST_200HR_Task_1_2019
        Me.pictablelayout.Location = New System.Drawing.Point(431, 195)
        Me.pictablelayout.Name = "pictablelayout"
        Me.pictablelayout.Size = New System.Drawing.Size(275, 125)
        Me.pictablelayout.TabIndex = 95
        Me.pictablelayout.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Restaurant_Booking_System_Andrew_Youssef.My.Resources.Resources.Restaurant_Logo__Small_3
        Me.PictureBox1.Location = New System.Drawing.Point(629, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 44)
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        '
        'frmconfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(732, 450)
        Me.Controls.Add(Me.btnbacktotables)
        Me.Controls.Add(Me.btnbacktoorders)
        Me.Controls.Add(Me.lbldollarsign7)
        Me.Controls.Add(Me.lblgst)
        Me.Controls.Add(Me.lblgstdisplay)
        Me.Controls.Add(Me.lbltablelayout)
        Me.Controls.Add(Me.pictablelayout)
        Me.Controls.Add(Me.lbldollarsign8)
        Me.Controls.Add(Me.lbldollarsign6)
        Me.Controls.Add(Me.lbldollarsign5)
        Me.Controls.Add(Me.lbldollarsign4)
        Me.Controls.Add(Me.lbldollarsign3)
        Me.Controls.Add(Me.lbldollarsign2)
        Me.Controls.Add(Me.lbldollarsign1)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lbltotaldisplay)
        Me.Controls.Add(Me.lblremoval)
        Me.Controls.Add(Me.lblextra)
        Me.Controls.Add(Me.lblremovaldisplay)
        Me.Controls.Add(Me.lblextradisplay)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnconfirm)
        Me.Controls.Add(Me.lbltable)
        Me.Controls.Add(Me.lbltabledisplay)
        Me.Controls.Add(Me.lbldrink)
        Me.Controls.Add(Me.lbldessert)
        Me.Controls.Add(Me.lblmain)
        Me.Controls.Add(Me.lblentree)
        Me.Controls.Add(Me.lblpeople)
        Me.Controls.Add(Me.lbldrinkdisplay)
        Me.Controls.Add(Me.lbldessertdisplay)
        Me.Controls.Add(Me.lblmaindisplay)
        Me.Controls.Add(Me.lblentreedisplay)
        Me.Controls.Add(Me.lblpeopledisplay)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblconfirmationtitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmconfirmation"
        Me.Text = "Confirmation"
        CType(Me.pictablelayout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblconfirmationtitle As Label
    Friend WithEvents btnclose As Button
    Friend WithEvents lblpeopledisplay As Label
    Friend WithEvents lblentreedisplay As Label
    Friend WithEvents lblmaindisplay As Label
    Friend WithEvents lbldessertdisplay As Label
    Friend WithEvents lbldrinkdisplay As Label
    Friend WithEvents lblpeople As Label
    Friend WithEvents lblentree As Label
    Friend WithEvents lblmain As Label
    Friend WithEvents lbldessert As Label
    Friend WithEvents lbldrink As Label
    Friend WithEvents lbltabledisplay As Label
    Friend WithEvents lbltable As Label
    Friend WithEvents btnconfirm As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblremoval As Label
    Friend WithEvents lblextra As Label
    Friend WithEvents lblremovaldisplay As Label
    Friend WithEvents lblextradisplay As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lbltotaldisplay As Label
    Friend WithEvents lbldollarsign8 As Label
    Friend WithEvents lbldollarsign6 As Label
    Friend WithEvents lbldollarsign5 As Label
    Friend WithEvents lbldollarsign4 As Label
    Friend WithEvents lbldollarsign3 As Label
    Friend WithEvents lbldollarsign2 As Label
    Friend WithEvents lbldollarsign1 As Label
    Friend WithEvents pictablelayout As PictureBox
    Friend WithEvents lbltablelayout As Label
    Friend WithEvents lbldollarsign7 As Label
    Friend WithEvents lblgst As Label
    Friend WithEvents lblgstdisplay As Label
    Friend WithEvents btnbacktoorders As Button
    Friend WithEvents btnbacktotables As Button
End Class
