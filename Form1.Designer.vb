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
        Me.btnTestOracle = New System.Windows.Forms.Button
        Me.lblHeader = New System.Windows.Forms.Label
        Me.btnListAllSKUs = New System.Windows.Forms.Button
        Me.btnListAllLOCs = New System.Windows.Forms.Button
        Me.btnListAllBoxes = New System.Windows.Forms.Button
        Me.btnListAllCounts = New System.Windows.Forms.Button
        Me.btnListOneLOC = New System.Windows.Forms.Button
        Me.btnClearOutBox = New System.Windows.Forms.Button
        Me.outbox = New System.Windows.Forms.TextBox
        Me.btnAddSKU = New System.Windows.Forms.Button
        Me.btnAddLOC = New System.Windows.Forms.Button
        Me.btnAddBox = New System.Windows.Forms.Button
        Me.btnResetTables = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSetMaxQuantity = New System.Windows.Forms.Button
        Me.btnMoveBox = New System.Windows.Forms.Button
        Me.btnDeleteBox = New System.Windows.Forms.Button
        Me.btnDeleteSKU = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnTestOracle
        '
        Me.btnTestOracle.Location = New System.Drawing.Point(1156, 578)
        Me.btnTestOracle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTestOracle.Name = "btnTestOracle"
        Me.btnTestOracle.Size = New System.Drawing.Size(112, 28)
        Me.btnTestOracle.TabIndex = 0
        Me.btnTestOracle.Text = "Test Oracle"
        Me.btnTestOracle.UseVisualStyleBackColor = True
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(93, 11)
        Me.lblHeader.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(100, 16)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Assignment 2"
        '
        'btnListAllSKUs
        '
        Me.btnListAllSKUs.Location = New System.Drawing.Point(114, 103)
        Me.btnListAllSKUs.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListAllSKUs.Name = "btnListAllSKUs"
        Me.btnListAllSKUs.Size = New System.Drawing.Size(130, 28)
        Me.btnListAllSKUs.TabIndex = 2
        Me.btnListAllSKUs.Text = "List All SKUs"
        Me.btnListAllSKUs.UseVisualStyleBackColor = True
        '
        'btnListAllLOCs
        '
        Me.btnListAllLOCs.Location = New System.Drawing.Point(114, 167)
        Me.btnListAllLOCs.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListAllLOCs.Name = "btnListAllLOCs"
        Me.btnListAllLOCs.Size = New System.Drawing.Size(130, 28)
        Me.btnListAllLOCs.TabIndex = 3
        Me.btnListAllLOCs.Text = "List All LOCs"
        Me.btnListAllLOCs.UseVisualStyleBackColor = True
        '
        'btnListAllBoxes
        '
        Me.btnListAllBoxes.Location = New System.Drawing.Point(114, 235)
        Me.btnListAllBoxes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListAllBoxes.Name = "btnListAllBoxes"
        Me.btnListAllBoxes.Size = New System.Drawing.Size(130, 28)
        Me.btnListAllBoxes.TabIndex = 4
        Me.btnListAllBoxes.Text = "List All Boxes"
        Me.btnListAllBoxes.UseVisualStyleBackColor = True
        '
        'btnListAllCounts
        '
        Me.btnListAllCounts.Location = New System.Drawing.Point(114, 304)
        Me.btnListAllCounts.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListAllCounts.Name = "btnListAllCounts"
        Me.btnListAllCounts.Size = New System.Drawing.Size(130, 28)
        Me.btnListAllCounts.TabIndex = 5
        Me.btnListAllCounts.Text = "List All Counts"
        Me.btnListAllCounts.UseVisualStyleBackColor = True
        '
        'btnListOneLOC
        '
        Me.btnListOneLOC.Location = New System.Drawing.Point(114, 370)
        Me.btnListOneLOC.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListOneLOC.Name = "btnListOneLOC"
        Me.btnListOneLOC.Size = New System.Drawing.Size(130, 28)
        Me.btnListOneLOC.TabIndex = 6
        Me.btnListOneLOC.Text = "List One LOC"
        Me.btnListOneLOC.UseVisualStyleBackColor = True
        '
        'btnClearOutBox
        '
        Me.btnClearOutBox.Location = New System.Drawing.Point(114, 436)
        Me.btnClearOutBox.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClearOutBox.Name = "btnClearOutBox"
        Me.btnClearOutBox.Size = New System.Drawing.Size(130, 28)
        Me.btnClearOutBox.TabIndex = 7
        Me.btnClearOutBox.Text = "Clear OutBox"
        Me.btnClearOutBox.UseVisualStyleBackColor = True
        '
        'outbox
        '
        Me.outbox.Location = New System.Drawing.Point(654, 32)
        Me.outbox.Margin = New System.Windows.Forms.Padding(4)
        Me.outbox.Multiline = True
        Me.outbox.Name = "outbox"
        Me.outbox.ReadOnly = True
        Me.outbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.outbox.Size = New System.Drawing.Size(518, 499)
        Me.outbox.TabIndex = 8
        '
        'btnAddSKU
        '
        Me.btnAddSKU.Location = New System.Drawing.Point(356, 102)
        Me.btnAddSKU.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddSKU.Name = "btnAddSKU"
        Me.btnAddSKU.Size = New System.Drawing.Size(134, 28)
        Me.btnAddSKU.TabIndex = 9
        Me.btnAddSKU.Text = "Add SKU"
        Me.btnAddSKU.UseVisualStyleBackColor = True
        '
        'btnAddLOC
        '
        Me.btnAddLOC.Location = New System.Drawing.Point(356, 167)
        Me.btnAddLOC.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddLOC.Name = "btnAddLOC"
        Me.btnAddLOC.Size = New System.Drawing.Size(134, 28)
        Me.btnAddLOC.TabIndex = 10
        Me.btnAddLOC.Text = "Add LOC"
        Me.btnAddLOC.UseVisualStyleBackColor = True
        '
        'btnAddBox
        '
        Me.btnAddBox.Location = New System.Drawing.Point(356, 235)
        Me.btnAddBox.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddBox.Name = "btnAddBox"
        Me.btnAddBox.Size = New System.Drawing.Size(134, 28)
        Me.btnAddBox.TabIndex = 11
        Me.btnAddBox.Text = "Add Box"
        Me.btnAddBox.UseVisualStyleBackColor = True
        '
        'btnResetTables
        '
        Me.btnResetTables.Location = New System.Drawing.Point(114, 503)
        Me.btnResetTables.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResetTables.Name = "btnResetTables"
        Me.btnResetTables.Size = New System.Drawing.Size(134, 28)
        Me.btnResetTables.TabIndex = 12
        Me.btnResetTables.Text = "Reset Tables"
        Me.btnResetTables.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Student Name : Vivek Patil "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(93, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Student ID: 1784765"
        '
        'btnSetMaxQuantity
        '
        Me.btnSetMaxQuantity.Location = New System.Drawing.Point(356, 304)
        Me.btnSetMaxQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSetMaxQuantity.Name = "btnSetMaxQuantity"
        Me.btnSetMaxQuantity.Size = New System.Drawing.Size(134, 28)
        Me.btnSetMaxQuantity.TabIndex = 15
        Me.btnSetMaxQuantity.Text = "Set Max Quantity"
        Me.btnSetMaxQuantity.UseVisualStyleBackColor = True
        '
        'btnMoveBox
        '
        Me.btnMoveBox.Location = New System.Drawing.Point(356, 370)
        Me.btnMoveBox.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMoveBox.Name = "btnMoveBox"
        Me.btnMoveBox.Size = New System.Drawing.Size(134, 28)
        Me.btnMoveBox.TabIndex = 16
        Me.btnMoveBox.Text = "Move Box"
        Me.btnMoveBox.UseVisualStyleBackColor = True
        '
        'btnDeleteBox
        '
        Me.btnDeleteBox.Location = New System.Drawing.Point(356, 436)
        Me.btnDeleteBox.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteBox.Name = "btnDeleteBox"
        Me.btnDeleteBox.Size = New System.Drawing.Size(134, 28)
        Me.btnDeleteBox.TabIndex = 17
        Me.btnDeleteBox.Text = "Delete Box"
        Me.btnDeleteBox.UseVisualStyleBackColor = True
        '
        'btnDeleteSKU
        '
        Me.btnDeleteSKU.Location = New System.Drawing.Point(356, 503)
        Me.btnDeleteSKU.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteSKU.Name = "btnDeleteSKU"
        Me.btnDeleteSKU.Size = New System.Drawing.Size(134, 28)
        Me.btnDeleteSKU.TabIndex = 18
        Me.btnDeleteSKU.Text = "Delete SKU"
        Me.btnDeleteSKU.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 651)
        Me.Controls.Add(Me.btnDeleteSKU)
        Me.Controls.Add(Me.btnDeleteBox)
        Me.Controls.Add(Me.btnMoveBox)
        Me.Controls.Add(Me.btnSetMaxQuantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnResetTables)
        Me.Controls.Add(Me.btnAddBox)
        Me.Controls.Add(Me.btnAddLOC)
        Me.Controls.Add(Me.btnAddSKU)
        Me.Controls.Add(Me.outbox)
        Me.Controls.Add(Me.btnClearOutBox)
        Me.Controls.Add(Me.btnListOneLOC)
        Me.Controls.Add(Me.btnListAllCounts)
        Me.Controls.Add(Me.btnListAllBoxes)
        Me.Controls.Add(Me.btnListAllLOCs)
        Me.Controls.Add(Me.btnListAllSKUs)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.btnTestOracle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTestOracle As System.Windows.Forms.Button
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents btnListAllSKUs As System.Windows.Forms.Button
    Friend WithEvents btnListAllLOCs As System.Windows.Forms.Button
    Friend WithEvents btnListAllBoxes As System.Windows.Forms.Button
    Friend WithEvents btnListAllCounts As System.Windows.Forms.Button
    Friend WithEvents btnListOneLOC As System.Windows.Forms.Button
    Friend WithEvents btnClearOutBox As System.Windows.Forms.Button
    Friend WithEvents outbox As System.Windows.Forms.TextBox
    Friend WithEvents btnAddSKU As System.Windows.Forms.Button
    Friend WithEvents btnAddLOC As System.Windows.Forms.Button
    Friend WithEvents btnAddBox As System.Windows.Forms.Button
    Friend WithEvents btnResetTables As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSetMaxQuantity As System.Windows.Forms.Button
    Friend WithEvents btnMoveBox As System.Windows.Forms.Button
    Friend WithEvents btnDeleteBox As System.Windows.Forms.Button
    Friend WithEvents btnDeleteSKU As System.Windows.Forms.Button

End Class
