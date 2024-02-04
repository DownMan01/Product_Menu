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
        Me.registration = New System.Windows.Forms.Button()
        Me.purchasing = New System.Windows.Forms.Button()
        Me.inventory = New System.Windows.Forms.Button()
        Me.sales = New System.Windows.Forms.Button()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'registration
        '
        Me.registration.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.registration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registration.Location = New System.Drawing.Point(322, 168)
        Me.registration.Name = "registration"
        Me.registration.Size = New System.Drawing.Size(195, 48)
        Me.registration.TabIndex = 0
        Me.registration.Text = "Product Registration"
        Me.registration.UseVisualStyleBackColor = True
        '
        'purchasing
        '
        Me.purchasing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchasing.Location = New System.Drawing.Point(322, 247)
        Me.purchasing.Name = "purchasing"
        Me.purchasing.Size = New System.Drawing.Size(195, 48)
        Me.purchasing.TabIndex = 1
        Me.purchasing.Text = "Purchasing"
        Me.purchasing.UseVisualStyleBackColor = True
        '
        'inventory
        '
        Me.inventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventory.Location = New System.Drawing.Point(322, 326)
        Me.inventory.Name = "inventory"
        Me.inventory.Size = New System.Drawing.Size(195, 48)
        Me.inventory.TabIndex = 2
        Me.inventory.Text = "Product Inventory"
        Me.inventory.UseVisualStyleBackColor = True
        '
        'sales
        '
        Me.sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sales.Location = New System.Drawing.Point(322, 406)
        Me.sales.Name = "sales"
        Me.sales.Size = New System.Drawing.Size(195, 48)
        Me.sales.TabIndex = 3
        Me.sales.Text = "Sales"
        Me.sales.UseVisualStyleBackColor = True
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.Location = New System.Drawing.Point(322, 485)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(195, 48)
        Me.closeBtn.TabIndex = 4
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(362, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 45)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "MENU"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 711)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.sales)
        Me.Controls.Add(Me.inventory)
        Me.Controls.Add(Me.purchasing)
        Me.Controls.Add(Me.registration)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents registration As Button
    Friend WithEvents purchasing As Button
    Friend WithEvents inventory As Button
    Friend WithEvents sales As Button
    Friend WithEvents closeBtn As Button
    Friend WithEvents Label1 As Label
End Class
