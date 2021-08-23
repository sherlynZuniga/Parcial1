<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grande = New System.Windows.Forms.RadioButton()
        Me.mediano = New System.Windows.Forms.RadioButton()
        Me.pequeño = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cantidadazucenas = New System.Windows.Forms.TextBox()
        Me.tipoazucena = New System.Windows.Forms.CheckBox()
        Me.cantidadexoticas = New System.Windows.Forms.TextBox()
        Me.cantidadgerberas = New System.Windows.Forms.TextBox()
        Me.cantidadrosas = New System.Windows.Forms.TextBox()
        Me.tipoexoticas = New System.Windows.Forms.CheckBox()
        Me.tipogerberas = New System.Windows.Forms.CheckBox()
        Me.tiporosas = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.subtotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.descuento = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.NavajoWhite
        Me.GroupBox1.Controls.Add(Me.grande)
        Me.GroupBox1.Controls.Add(Me.mediano)
        Me.GroupBox1.Controls.Add(Me.pequeño)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(109, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de arreglo"
        '
        'grande
        '
        Me.grande.AutoSize = True
        Me.grande.BackColor = System.Drawing.Color.SandyBrown
        Me.grande.Location = New System.Drawing.Point(6, 75)
        Me.grande.Name = "grande"
        Me.grande.Size = New System.Drawing.Size(63, 19)
        Me.grande.TabIndex = 1
        Me.grande.TabStop = True
        Me.grande.Text = "Grande"
        Me.grande.UseVisualStyleBackColor = False
        '
        'mediano
        '
        Me.mediano.AutoSize = True
        Me.mediano.BackColor = System.Drawing.Color.SandyBrown
        Me.mediano.Location = New System.Drawing.Point(7, 48)
        Me.mediano.Name = "mediano"
        Me.mediano.Size = New System.Drawing.Size(72, 19)
        Me.mediano.TabIndex = 1
        Me.mediano.TabStop = True
        Me.mediano.Text = "Mediano"
        Me.mediano.UseVisualStyleBackColor = False
        '
        'pequeño
        '
        Me.pequeño.AutoSize = True
        Me.pequeño.BackColor = System.Drawing.Color.SandyBrown
        Me.pequeño.Location = New System.Drawing.Point(7, 23)
        Me.pequeño.Name = "pequeño"
        Me.pequeño.Size = New System.Drawing.Size(72, 19)
        Me.pequeño.TabIndex = 0
        Me.pequeño.TabStop = True
        Me.pequeño.Text = "Pequeño"
        Me.pequeño.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PaleGreen
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cantidadazucenas)
        Me.GroupBox2.Controls.Add(Me.tipoazucena)
        Me.GroupBox2.Controls.Add(Me.cantidadexoticas)
        Me.GroupBox2.Controls.Add(Me.cantidadgerberas)
        Me.GroupBox2.Controls.Add(Me.cantidadrosas)
        Me.GroupBox2.Controls.Add(Me.tipoexoticas)
        Me.GroupBox2.Controls.Add(Me.tipogerberas)
        Me.GroupBox2.Controls.Add(Me.tiporosas)
        Me.GroupBox2.Location = New System.Drawing.Point(150, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(175, 138)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de flores:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label1.Location = New System.Drawing.Point(103, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cantidad"
        '
        'cantidadazucenas
        '
        Me.cantidadazucenas.Location = New System.Drawing.Point(100, 109)
        Me.cantidadazucenas.Name = "cantidadazucenas"
        Me.cantidadazucenas.Size = New System.Drawing.Size(58, 23)
        Me.cantidadazucenas.TabIndex = 5
        '
        'tipoazucena
        '
        Me.tipoazucena.AutoSize = True
        Me.tipoazucena.BackColor = System.Drawing.Color.SpringGreen
        Me.tipoazucena.Location = New System.Drawing.Point(7, 113)
        Me.tipoazucena.Name = "tipoazucena"
        Me.tipoazucena.Size = New System.Drawing.Size(76, 19)
        Me.tipoazucena.TabIndex = 3
        Me.tipoazucena.Text = "Azucenas"
        Me.tipoazucena.UseVisualStyleBackColor = False
        '
        'cantidadexoticas
        '
        Me.cantidadexoticas.Location = New System.Drawing.Point(100, 80)
        Me.cantidadexoticas.Name = "cantidadexoticas"
        Me.cantidadexoticas.Size = New System.Drawing.Size(58, 23)
        Me.cantidadexoticas.TabIndex = 4
        '
        'cantidadgerberas
        '
        Me.cantidadgerberas.Location = New System.Drawing.Point(100, 55)
        Me.cantidadgerberas.Name = "cantidadgerberas"
        Me.cantidadgerberas.Size = New System.Drawing.Size(58, 23)
        Me.cantidadgerberas.TabIndex = 4
        '
        'cantidadrosas
        '
        Me.cantidadrosas.Location = New System.Drawing.Point(100, 27)
        Me.cantidadrosas.Name = "cantidadrosas"
        Me.cantidadrosas.Size = New System.Drawing.Size(58, 23)
        Me.cantidadrosas.TabIndex = 3
        '
        'tipoexoticas
        '
        Me.tipoexoticas.AutoSize = True
        Me.tipoexoticas.BackColor = System.Drawing.Color.SpringGreen
        Me.tipoexoticas.Location = New System.Drawing.Point(7, 84)
        Me.tipoexoticas.Name = "tipoexoticas"
        Me.tipoexoticas.Size = New System.Drawing.Size(69, 19)
        Me.tipoexoticas.TabIndex = 2
        Me.tipoexoticas.Text = "Exóticas"
        Me.tipoexoticas.UseVisualStyleBackColor = False
        '
        'tipogerberas
        '
        Me.tipogerberas.AutoSize = True
        Me.tipogerberas.BackColor = System.Drawing.Color.SpringGreen
        Me.tipogerberas.Location = New System.Drawing.Point(6, 57)
        Me.tipogerberas.Name = "tipogerberas"
        Me.tipogerberas.Size = New System.Drawing.Size(72, 19)
        Me.tipogerberas.TabIndex = 1
        Me.tipogerberas.Text = "Gerberas"
        Me.tipogerberas.UseVisualStyleBackColor = False
        '
        'tiporosas
        '
        Me.tiporosas.AutoSize = True
        Me.tiporosas.BackColor = System.Drawing.Color.SpringGreen
        Me.tiporosas.Location = New System.Drawing.Point(7, 27)
        Me.tiporosas.Name = "tiporosas"
        Me.tiporosas.Size = New System.Drawing.Size(56, 19)
        Me.tiporosas.TabIndex = 0
        Me.tiporosas.Text = "Rosas"
        Me.tiporosas.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Aquamarine
        Me.Label2.Location = New System.Drawing.Point(7, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Subtotal"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Tomato
        Me.Button1.Location = New System.Drawing.Point(233, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 73)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "CALCULAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkOrange
        Me.Button2.Location = New System.Drawing.Point(233, 260)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "LIMPIAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSalmon
        Me.Button3.Location = New System.Drawing.Point(233, 289)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'subtotal
        '
        Me.subtotal.Location = New System.Drawing.Point(95, 22)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(57, 23)
        Me.subtotal.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Aquamarine
        Me.Label3.Location = New System.Drawing.Point(7, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Descuento 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Aquamarine
        Me.Label4.Location = New System.Drawing.Point(7, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total a pagar"
        '
        'descuento
        '
        Me.descuento.Location = New System.Drawing.Point(95, 55)
        Me.descuento.Name = "descuento"
        Me.descuento.Size = New System.Drawing.Size(57, 23)
        Me.descuento.TabIndex = 9
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(95, 90)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(57, 23)
        Me.total.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.total)
        Me.GroupBox3.Controls.Add(Me.subtotal)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.descuento)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 181)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(191, 126)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total a pagar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(346, 330)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "201904030_FLORES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grande As RadioButton
    Friend WithEvents mediano As RadioButton
    Friend WithEvents pequeño As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cantidadexoticas As TextBox
    Friend WithEvents cantidadgerberas As TextBox
    Friend WithEvents cantidadrosas As TextBox
    Friend WithEvents tipoexoticas As CheckBox
    Friend WithEvents tipogerberas As CheckBox
    Friend WithEvents tiporosas As CheckBox
    Friend WithEvents tipoazucena As CheckBox
    Friend WithEvents cantidadazucenas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents subtotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents descuento As TextBox
    Friend WithEvents total As TextBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
