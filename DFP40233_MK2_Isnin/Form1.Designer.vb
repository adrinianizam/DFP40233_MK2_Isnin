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
        lblMaklumatPelangan = New Label()
        lblNama = New Label()
        lblNoTel = New Label()
        lblAlamat = New Label()
        lblNegeri = New Label()
        lblJantina = New Label()
        lblKaedahBayaran = New Label()
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
        lblPerisa = New Label()
        GroupBox3 = New GroupBox()
        chkPisang = New CheckBox()
        chkStrawberi = New CheckBox()
        chkCoklat = New CheckBox()
        chkKopi = New CheckBox()
        chkMilo = New CheckBox()
        lblTarikh = New Label()
        dtePicker = New DateTimePicker()
        dgv = New DataGridView()
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
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblMaklumatPelangan
        ' 
        lblMaklumatPelangan.AutoSize = True
        lblMaklumatPelangan.Font = New Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblMaklumatPelangan.Location = New Point(35, 22)
        lblMaklumatPelangan.Name = "lblMaklumatPelangan"
        lblMaklumatPelangan.Size = New Size(270, 26)
        lblMaklumatPelangan.TabIndex = 0
        lblMaklumatPelangan.Text = "MAKLUMAT PELANGGAN"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(35, 78)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(50, 19)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama"
        ' 
        ' lblNoTel
        ' 
        lblNoTel.AutoSize = True
        lblNoTel.Font = New Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblNoTel.Location = New Point(35, 119)
        lblNoTel.Name = "lblNoTel"
        lblNoTel.Size = New Size(88, 19)
        lblNoTel.TabIndex = 2
        lblNoTel.Text = "No. Telefon"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Font = New Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblAlamat.Location = New Point(35, 165)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(59, 19)
        lblAlamat.TabIndex = 3
        lblAlamat.Text = "Alamat"
        ' 
        ' lblNegeri
        ' 
        lblNegeri.AutoSize = True
        lblNegeri.Font = New Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblNegeri.Location = New Point(35, 275)
        lblNegeri.Name = "lblNegeri"
        lblNegeri.Size = New Size(57, 19)
        lblNegeri.TabIndex = 4
        lblNegeri.Text = "Negeri"
        ' 
        ' lblJantina
        ' 
        lblJantina.AutoSize = True
        lblJantina.Font = New Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblJantina.Location = New Point(35, 329)
        lblJantina.Name = "lblJantina"
        lblJantina.Size = New Size(63, 19)
        lblJantina.TabIndex = 5
        lblJantina.Text = "Jantina"
        ' 
        ' lblKaedahBayaran
        ' 
        lblKaedahBayaran.AutoSize = True
        lblKaedahBayaran.Font = New Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblKaedahBayaran.Location = New Point(35, 418)
        lblKaedahBayaran.Name = "lblKaedahBayaran"
        lblKaedahBayaran.Size = New Size(129, 19)
        lblKaedahBayaran.TabIndex = 6
        lblKaedahBayaran.Text = "Kaedah Bayaran"
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
        ' lblPerisa
        ' 
        lblPerisa.AutoSize = True
        lblPerisa.Font = New Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblPerisa.Location = New Point(443, 78)
        lblPerisa.Name = "lblPerisa"
        lblPerisa.Size = New Size(55, 19)
        lblPerisa.TabIndex = 13
        lblPerisa.Text = "Perisa"
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
        ' lblTarikh
        ' 
        lblTarikh.AutoSize = True
        lblTarikh.Font = New Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTarikh.Location = New Point(443, 217)
        lblTarikh.Name = "lblTarikh"
        lblTarikh.Size = New Size(54, 19)
        lblTarikh.TabIndex = 15
        lblTarikh.Text = "Tarikh"
        ' 
        ' dtePicker
        ' 
        dtePicker.Font = New Font("Times New Roman", 9F)
        dtePicker.Location = New Point(509, 210)
        dtePicker.Name = "dtePicker"
        dtePicker.Size = New Size(244, 25)
        dtePicker.TabIndex = 16
        ' 
        ' dgv
        ' 
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        dgv.Location = New Point(443, 275)
        dgv.Name = "dgv"
        dgv.RowHeadersWidth = 51
        dgv.Size = New Size(417, 81)
        dgv.TabIndex = 17
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
        Controls.Add(dgv)
        Controls.Add(dtePicker)
        Controls.Add(lblTarikh)
        Controls.Add(GroupBox3)
        Controls.Add(lblPerisa)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(cmbNegeri)
        Controls.Add(txtAlamat)
        Controls.Add(txtNoTelefon)
        Controls.Add(txtNama)
        Controls.Add(lblKaedahBayaran)
        Controls.Add(lblJantina)
        Controls.Add(lblNegeri)
        Controls.Add(lblAlamat)
        Controls.Add(lblNoTel)
        Controls.Add(lblNama)
        Controls.Add(lblMaklumatPelangan)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMaklumatPelangan As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNoTel As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblNegeri As Label
    Friend WithEvents lblJantina As Label
    Friend WithEvents lblKaedahBayaran As Label
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
    Friend WithEvents lblPerisa As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkPisang As CheckBox
    Friend WithEvents chkStrawberi As CheckBox
    Friend WithEvents chkCoklat As CheckBox
    Friend WithEvents chkKopi As CheckBox
    Friend WithEvents chkMilo As CheckBox
    Friend WithEvents lblTarikh As Label
    Friend WithEvents dtePicker As DateTimePicker
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnRead As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button

End Class
