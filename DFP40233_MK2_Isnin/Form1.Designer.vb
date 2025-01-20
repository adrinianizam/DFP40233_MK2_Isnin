<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtNama = New TextBox()
        txtNoTelefon = New TextBox()
        txtAlamat = New TextBox()
        cmbNegeri = New ComboBox()
        GroupBox1 = New GroupBox()
        rbtnWanita = New RadioButton()
        rbtnLelaki = New RadioButton()
        GroupBox2 = New GroupBox()
        rbtnCashless = New RadioButton()
        rbtnCash = New RadioButton()
        Label8 = New Label()
        GroupBox3 = New GroupBox()
        chkPisang = New CheckBox()
        chkStrawberi = New CheckBox()
        chkCoklat = New CheckBox()
        chkKopi = New CheckBox()
        chkMilo = New CheckBox()
        Label9 = New Label()
        datePicker = New DateTimePicker()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        BtnCreate = New Button()
        BtnRead = New Button()
        BtnUpdate = New Button()
        BtnDelete = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(35, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(270, 26)
        Label1.TabIndex = 0
        Label1.Text = "MAKLUMAT PELANGGAN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(35, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 19)
        Label2.TabIndex = 1
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(35, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 19)
        Label3.TabIndex = 2
        Label3.Text = "No. Telefon"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(35, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 19)
        Label4.TabIndex = 3
        Label4.Text = "Alamat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(35, 275)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 19)
        Label5.TabIndex = 4
        Label5.Text = "Negeri"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(35, 329)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 19)
        Label6.TabIndex = 5
        Label6.Text = "Jantina"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(35, 418)
        Label7.Name = "Label7"
        Label7.Size = New Size(129, 19)
        Label7.TabIndex = 6
        Label7.Text = "Kaedah Bayaran"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(185, 71)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(188, 27)
        txtNama.TabIndex = 7
        ' 
        ' txtNoTelefon
        ' 
        txtNoTelefon.Location = New Point(185, 116)
        txtNoTelefon.Name = "txtNoTelefon"
        txtNoTelefon.Size = New Size(188, 27)
        txtNoTelefon.TabIndex = 8
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(185, 165)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(188, 81)
        txtAlamat.TabIndex = 9
        ' 
        ' cmbNegeri
        ' 
        cmbNegeri.FormattingEnabled = True
        cmbNegeri.Items.AddRange(New Object() {"Johor", "Melaka", "Pahang", "Negeri Sembilan", "Selangor", "Perak", "Terengganu", "Kelantan", "Pulau Pinang", "Kedah", "Perlis", "Sabah", "Sarawak"})
        cmbNegeri.Location = New Point(185, 267)
        cmbNegeri.Name = "cmbNegeri"
        cmbNegeri.Size = New Size(188, 28)
        cmbNegeri.TabIndex = 10
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbtnWanita)
        GroupBox1.Controls.Add(rbtnLelaki)
        GroupBox1.Font = New Font("Times New Roman", 9F)
        GroupBox1.Location = New Point(185, 312)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(188, 68)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        ' 
        ' rbtnWanita
        ' 
        rbtnWanita.AutoSize = True
        rbtnWanita.Location = New Point(6, 38)
        rbtnWanita.Name = "rbtnWanita"
        rbtnWanita.Size = New Size(70, 21)
        rbtnWanita.TabIndex = 1
        rbtnWanita.TabStop = True
        rbtnWanita.Text = "Wanita"
        rbtnWanita.UseVisualStyleBackColor = True
        ' 
        ' rbtnLelaki
        ' 
        rbtnLelaki.AutoSize = True
        rbtnLelaki.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbtnLelaki.Location = New Point(6, 13)
        rbtnLelaki.Name = "rbtnLelaki"
        rbtnLelaki.Size = New Size(65, 21)
        rbtnLelaki.TabIndex = 0
        rbtnLelaki.TabStop = True
        rbtnLelaki.Text = "Lelaki"
        rbtnLelaki.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(rbtnCashless)
        GroupBox2.Controls.Add(rbtnCash)
        GroupBox2.Font = New Font("Times New Roman", 9F)
        GroupBox2.Location = New Point(185, 399)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(193, 77)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        ' 
        ' rbtnCashless
        ' 
        rbtnCashless.AutoSize = True
        rbtnCashless.Location = New Point(11, 46)
        rbtnCashless.Name = "rbtnCashless"
        rbtnCashless.Size = New Size(81, 21)
        rbtnCashless.TabIndex = 1
        rbtnCashless.TabStop = True
        rbtnCashless.Text = "Cashless"
        rbtnCashless.UseVisualStyleBackColor = True
        ' 
        ' rbtnCash
        ' 
        rbtnCash.AutoSize = True
        rbtnCash.Location = New Point(11, 16)
        rbtnCash.Name = "rbtnCash"
        rbtnCash.Size = New Size(59, 21)
        rbtnCash.TabIndex = 0
        rbtnCash.TabStop = True
        rbtnCash.Text = "Cash"
        rbtnCash.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(443, 78)
        Label8.Name = "Label8"
        Label8.Size = New Size(55, 19)
        Label8.TabIndex = 13
        Label8.Text = "Perisa"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(chkPisang)
        GroupBox3.Controls.Add(chkStrawberi)
        GroupBox3.Controls.Add(chkCoklat)
        GroupBox3.Controls.Add(chkKopi)
        GroupBox3.Controls.Add(chkMilo)
        GroupBox3.Font = New Font("Times New Roman", 9F)
        GroupBox3.Location = New Point(509, 60)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(203, 114)
        GroupBox3.TabIndex = 14
        GroupBox3.TabStop = False
        ' 
        ' chkPisang
        ' 
        chkPisang.AutoSize = True
        chkPisang.Location = New Point(97, 53)
        chkPisang.Name = "chkPisang"
        chkPisang.Size = New Size(69, 21)
        chkPisang.TabIndex = 4
        chkPisang.Text = "Pisang"
        chkPisang.UseVisualStyleBackColor = True
        ' 
        ' chkStrawberi
        ' 
        chkStrawberi.AutoSize = True
        chkStrawberi.Location = New Point(97, 23)
        chkStrawberi.Name = "chkStrawberi"
        chkStrawberi.Size = New Size(87, 21)
        chkStrawberi.TabIndex = 3
        chkStrawberi.Text = "Strawberi"
        chkStrawberi.UseVisualStyleBackColor = True
        ' 
        ' chkCoklat
        ' 
        chkCoklat.AutoSize = True
        chkCoklat.Location = New Point(18, 83)
        chkCoklat.Name = "chkCoklat"
        chkCoklat.Size = New Size(68, 21)
        chkCoklat.TabIndex = 2
        chkCoklat.Text = "Coklat"
        chkCoklat.UseVisualStyleBackColor = True
        ' 
        ' chkKopi
        ' 
        chkKopi.AutoSize = True
        chkKopi.Location = New Point(18, 53)
        chkKopi.Name = "chkKopi"
        chkKopi.Size = New Size(58, 21)
        chkKopi.TabIndex = 1
        chkKopi.Text = "Kopi"
        chkKopi.UseVisualStyleBackColor = True
        ' 
        ' chkMilo
        ' 
        chkMilo.AutoSize = True
        chkMilo.Location = New Point(17, 23)
        chkMilo.Name = "chkMilo"
        chkMilo.Size = New Size(56, 21)
        chkMilo.TabIndex = 0
        chkMilo.Text = "Milo"
        chkMilo.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(443, 217)
        Label9.Name = "Label9"
        Label9.Size = New Size(54, 19)
        Label9.TabIndex = 15
        Label9.Text = "Tarikh"
        ' 
        ' datePicker
        ' 
        datePicker.Font = New Font("Times New Roman", 9F)
        datePicker.Location = New Point(509, 210)
        datePicker.Name = "datePicker"
        datePicker.Size = New Size(244, 25)
        datePicker.TabIndex = 16
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridView1.Location = New Point(443, 275)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(417, 81)
        DataGridView1.TabIndex = 17
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Bil."
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nama"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "No. Tel"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' BtnCreate
        ' 
        BtnCreate.Font = New Font("Times New Roman", 10.2F)
        BtnCreate.Location = New Point(509, 385)
        BtnCreate.Name = "BtnCreate"
        BtnCreate.Size = New Size(94, 29)
        BtnCreate.TabIndex = 18
        BtnCreate.Text = "Create"
        BtnCreate.UseVisualStyleBackColor = True
        ' 
        ' BtnRead
        ' 
        BtnRead.Font = New Font("Times New Roman", 10.2F)
        BtnRead.Location = New Point(509, 437)
        BtnRead.Name = "BtnRead"
        BtnRead.Size = New Size(94, 29)
        BtnRead.TabIndex = 19
        BtnRead.Text = "Read"
        BtnRead.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Font = New Font("Times New Roman", 10.2F)
        BtnUpdate.Location = New Point(631, 385)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(94, 29)
        BtnUpdate.TabIndex = 20
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Font = New Font("Times New Roman", 10.2F)
        BtnDelete.Location = New Point(631, 437)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(94, 29)
        BtnDelete.TabIndex = 21
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(889, 506)
        Controls.Add(BtnDelete)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnRead)
        Controls.Add(BtnCreate)
        Controls.Add(DataGridView1)
        Controls.Add(datePicker)
        Controls.Add(Label9)
        Controls.Add(GroupBox3)
        Controls.Add(Label8)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(cmbNegeri)
        Controls.Add(txtAlamat)
        Controls.Add(txtNoTelefon)
        Controls.Add(txtNama)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNoTelefon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents cmbNegeri As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnWanita As RadioButton
    Friend WithEvents rbtnLelaki As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtnCashless As RadioButton
    Friend WithEvents rbtnCash As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkPisang As CheckBox
    Friend WithEvents chkStrawberi As CheckBox
    Friend WithEvents chkCoklat As CheckBox
    Friend WithEvents chkKopi As CheckBox
    Friend WithEvents chkMilo As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents datePicker As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnRead As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button

End Class
