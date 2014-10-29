<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblWeek5Assignment = New System.Windows.Forms.Label()
        Me.lblWeek4Assignment = New System.Windows.Forms.Label()
        Me.lblWeek3Assignment = New System.Windows.Forms.Label()
        Me.lblWeek2Assignment = New System.Windows.Forms.Label()
        Me.lblWeek1Assignment = New System.Windows.Forms.Label()
        Me.lblWeek1Forum = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblWeek2Forum = New System.Windows.Forms.Label()
        Me.lblWeek3Forum = New System.Windows.Forms.Label()
        Me.lblWeek4Forum = New System.Windows.Forms.Label()
        Me.lblWeek5Forum = New System.Windows.Forms.Label()
        Me.lblWeek6Forum = New System.Windows.Forms.Label()
        Me.lblWeek7Forum = New System.Windows.Forms.Label()
        Me.lblWeek8Forum = New System.Windows.Forms.Label()
        Me.lblWeek6Assignment = New System.Windows.Forms.Label()
        Me.lblWeek7Assignment = New System.Windows.Forms.Label()
        Me.lblWeek8Assignment = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtAssignmentScore = New System.Windows.Forms.TextBox()
        Me.txtForumScore = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cobWeeks = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblLetterGrade = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblClassAverage = New System.Windows.Forms.Label()
        Me.lblFinalProjectScore = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblForumAverage = New System.Windows.Forms.Label()
        Me.lblAssignmentAverage = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnFinalScore = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblNameContainer = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Database51DataSet = New Deshner_FinalProject.My.MySettings()
        Me.GradeBookBindingSource = New System.Windows.Forms.BindingSource(Me.components)


        Me.btnExit = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()

        CType(Me.GradeBookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.66055!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.88235!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.47059!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblWeek5Assignment, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWeek4Assignment, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWeek3Assignment, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWeek2Assignment, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWeek1Assignment, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWeek1Forum, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWeek2Forum, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWeek3Forum, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWeek4Forum, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWeek5Forum, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWeek6Forum, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWeek7Forum, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWeek8Forum, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWeek6Assignment, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWeek7Assignment, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWeek8Assignment, 2, 8)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(332, 70)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(425, 240)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblWeek5Assignment
        '
        Me.lblWeek5Assignment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWeek5Assignment.AutoSize = True
        Me.lblWeek5Assignment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek5Assignment.Location = New System.Drawing.Point(314, 140)
        Me.lblWeek5Assignment.Name = "lblWeek5Assignment"
        Me.lblWeek5Assignment.Size = New System.Drawing.Size(49, 17)
        Me.lblWeek5Assignment.TabIndex = 23
        Me.lblWeek5Assignment.Text = "0 / 100"
        '
        'lblWeek4Assignment
        '
        Me.lblWeek4Assignment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWeek4Assignment.AutoSize = True
        Me.lblWeek4Assignment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek4Assignment.Location = New System.Drawing.Point(314, 113)
        Me.lblWeek4Assignment.Name = "lblWeek4Assignment"
        Me.lblWeek4Assignment.Size = New System.Drawing.Size(49, 17)
        Me.lblWeek4Assignment.TabIndex = 22
        Me.lblWeek4Assignment.Text = "0 / 100"
        '
        'lblWeek3Assignment
        '
        Me.lblWeek3Assignment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWeek3Assignment.AutoSize = True
        Me.lblWeek3Assignment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek3Assignment.Location = New System.Drawing.Point(314, 86)
        Me.lblWeek3Assignment.Name = "lblWeek3Assignment"
        Me.lblWeek3Assignment.Size = New System.Drawing.Size(49, 17)
        Me.lblWeek3Assignment.TabIndex = 21
        Me.lblWeek3Assignment.Text = "0 / 100"
        '
        'lblWeek2Assignment
        '
        Me.lblWeek2Assignment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWeek2Assignment.AutoSize = True
        Me.lblWeek2Assignment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek2Assignment.Location = New System.Drawing.Point(314, 59)
        Me.lblWeek2Assignment.Name = "lblWeek2Assignment"
        Me.lblWeek2Assignment.Size = New System.Drawing.Size(49, 17)
        Me.lblWeek2Assignment.TabIndex = 20
        Me.lblWeek2Assignment.Text = "0 / 100"
        '
        'lblWeek1Assignment
        '
        Me.lblWeek1Assignment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWeek1Assignment.AutoSize = True
        Me.lblWeek1Assignment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek1Assignment.Location = New System.Drawing.Point(314, 32)
        Me.lblWeek1Assignment.Name = "lblWeek1Assignment"
        Me.lblWeek1Assignment.Size = New System.Drawing.Size(49, 17)
        Me.lblWeek1Assignment.TabIndex = 19
        Me.lblWeek1Assignment.Text = "0 / 100"
        '
        'lblWeek1Forum
        '
        Me.lblWeek1Forum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWeek1Forum.AutoSize = True
        Me.lblWeek1Forum.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek1Forum.Location = New System.Drawing.Point(139, 32)
        Me.lblWeek1Forum.Name = "lblWeek1Forum"
        Me.lblWeek1Forum.Size = New System.Drawing.Size(49, 17)
        Me.lblWeek1Forum.TabIndex = 11
        Me.lblWeek1Forum.Text = "0 / 100"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Week 1 :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(298, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Assignments"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(138, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Forums"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Week"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Week 2 :"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Week 3 :"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Week 4 :"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Week 5 :"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Week 6 :"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 194)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Week 7 :"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Week 8 :"
        '
        'lblWeek2Forum
        '
        Me.lblWeek2Forum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWeek2Forum.AutoSize = True
        Me.lblWeek2Forum.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek2Forum.Location = New System.Drawing.Point(139, 59)
        Me.lblWeek2Forum.Name = "lblWeek2Forum"
        Me.lblWeek2Forum.Size = New System.Drawing.Size(49, 17)
        Me.lblWeek2Forum.TabIndex = 12
        Me.lblWeek2Forum.Text = "0 / 100"
        '
        'lblWeek3Forum
        '
        Me.lblWeek3Forum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWeek3Forum.AutoSize = True
        Me.lblWeek3Forum.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek3Forum.Location = New System.Drawing.Point(139, 86)
        Me.lblWeek3Forum.Name = "lblWeek3Forum"
        Me.lblWeek3Forum.Size = New System.Drawing.Size(49, 17)
        Me.lblWeek3Forum.TabIndex = 13
        Me.lblWeek3Forum.Text = "0 / 100"
        '
        'lblWeek4Forum
        '
        Me.lblWeek4Forum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWeek4Forum.AutoSize = True
        Me.lblWeek4Forum.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek4Forum.Location = New System.Drawing.Point(139, 113)
        Me.lblWeek4Forum.Name = "lblWeek4Forum"
        Me.lblWeek4Forum.Size = New System.Drawing.Size(49, 17)
        Me.lblWeek4Forum.TabIndex = 14
        Me.lblWeek4Forum.Text = "0 / 100"
        '
        'lblWeek5Forum
        '
        Me.lblWeek5Forum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWeek5Forum.AutoSize = True
        Me.lblWeek5Forum.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek5Forum.Location = New System.Drawing.Point(139, 140)
        Me.lblWeek5Forum.Name = "lblWeek5Forum"
        Me.lblWeek5Forum.Size = New System.Drawing.Size(49, 17)
        Me.lblWeek5Forum.TabIndex = 15
        Me.lblWeek5Forum.Text = "0 / 100"
        '
        'lblWeek6Forum
        '
        Me.lblWeek6Forum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWeek6Forum.AutoSize = True
        Me.lblWeek6Forum.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek6Forum.Location = New System.Drawing.Point(139, 167)
        Me.lblWeek6Forum.Name = "lblWeek6Forum"
        Me.lblWeek6Forum.Size = New System.Drawing.Size(49, 17)
        Me.lblWeek6Forum.TabIndex = 16
        Me.lblWeek6Forum.Text = "0 / 100"
        '
        'lblWeek7Forum
        '
        Me.lblWeek7Forum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWeek7Forum.AutoSize = True
        Me.lblWeek7Forum.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek7Forum.Location = New System.Drawing.Point(139, 194)
        Me.lblWeek7Forum.Name = "lblWeek7Forum"
        Me.lblWeek7Forum.Size = New System.Drawing.Size(49, 17)
        Me.lblWeek7Forum.TabIndex = 17
        Me.lblWeek7Forum.Text = "0 / 100"
        '
        'lblWeek8Forum
        '
        Me.lblWeek8Forum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWeek8Forum.AutoSize = True
        Me.lblWeek8Forum.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek8Forum.Location = New System.Drawing.Point(139, 219)
        Me.lblWeek8Forum.Name = "lblWeek8Forum"
        Me.lblWeek8Forum.Size = New System.Drawing.Size(49, 17)
        Me.lblWeek8Forum.TabIndex = 18
        Me.lblWeek8Forum.Text = "0 / 100"
        '
        'lblWeek6Assignment
        '
        Me.lblWeek6Assignment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWeek6Assignment.AutoSize = True
        Me.lblWeek6Assignment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek6Assignment.Location = New System.Drawing.Point(314, 167)
        Me.lblWeek6Assignment.Name = "lblWeek6Assignment"
        Me.lblWeek6Assignment.Size = New System.Drawing.Size(49, 17)
        Me.lblWeek6Assignment.TabIndex = 24
        Me.lblWeek6Assignment.Text = "0 / 100"
        '
        'lblWeek7Assignment
        '
        Me.lblWeek7Assignment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWeek7Assignment.AutoSize = True
        Me.lblWeek7Assignment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek7Assignment.Location = New System.Drawing.Point(314, 194)
        Me.lblWeek7Assignment.Name = "lblWeek7Assignment"
        Me.lblWeek7Assignment.Size = New System.Drawing.Size(49, 17)
        Me.lblWeek7Assignment.TabIndex = 25
        Me.lblWeek7Assignment.Text = "0 / 100"
        '
        'lblWeek8Assignment
        '
        Me.lblWeek8Assignment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWeek8Assignment.AutoSize = True
        Me.lblWeek8Assignment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek8Assignment.Location = New System.Drawing.Point(314, 219)
        Me.lblWeek8Assignment.Name = "lblWeek8Assignment"
        Me.lblWeek8Assignment.Size = New System.Drawing.Size(49, 17)
        Me.lblWeek8Assignment.TabIndex = 26
        Me.lblWeek8Assignment.Text = "0 / 100"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSubmit)
        Me.GroupBox1.Controls.Add(Me.txtAssignmentScore)
        Me.GroupBox1.Controls.Add(Me.txtForumScore)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cobWeeks)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 209)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Scores"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(9, 167)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 31)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtAssignmentScore
        '
        Me.txtAssignmentScore.Location = New System.Drawing.Point(155, 124)
        Me.txtAssignmentScore.Name = "txtAssignmentScore"
        Me.txtAssignmentScore.Size = New System.Drawing.Size(71, 25)
        Me.txtAssignmentScore.TabIndex = 2
        '
        'txtForumScore
        '
        Me.txtForumScore.Location = New System.Drawing.Point(155, 76)
        Me.txtForumScore.Name = "txtForumScore"
        Me.txtForumScore.Size = New System.Drawing.Size(71, 25)
        Me.txtForumScore.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 127)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 17)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Assignment Score :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 17)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Forum Score :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 17)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Week :"
        '
        'cobWeeks
        '
        Me.cobWeeks.FormattingEnabled = True
        Me.cobWeeks.Items.AddRange(New Object() {"Week 1", "Week 2", "Week 3", "Week 4", "Week 5", "Week 6", "Week 7", "Week 8"})
        Me.cobWeeks.Location = New System.Drawing.Point(155, 23)
        Me.cobWeeks.Name = "cobWeeks"
        Me.cobWeeks.Size = New System.Drawing.Size(71, 25)
        Me.cobWeeks.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnExit)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.lblLetterGrade)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.lblClassAverage)
        Me.GroupBox2.Controls.Add(Me.lblFinalProjectScore)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lblForumAverage)
        Me.GroupBox2.Controls.Add(Me.lblAssignmentAverage)
        Me.GroupBox2.Controls.Add(Me.btnCalculate)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(352, 333)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(405, 262)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Calculate Scores"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(189, 206)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 30)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblLetterGrade
        '
        Me.lblLetterGrade.AutoSize = True
        Me.lblLetterGrade.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterGrade.Location = New System.Drawing.Point(215, 163)
        Me.lblLetterGrade.Name = "lblLetterGrade"
        Me.lblLetterGrade.Size = New System.Drawing.Size(31, 17)
        Me.lblLetterGrade.TabIndex = 11
        Me.lblLetterGrade.Text = "Null"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(17, 163)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(182, 17)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "Letter Grade For the Quarter :"
        '
        'lblClassAverage
        '
        Me.lblClassAverage.AutoSize = True
        Me.lblClassAverage.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassAverage.Location = New System.Drawing.Point(215, 128)
        Me.lblClassAverage.Name = "lblClassAverage"
        Me.lblClassAverage.Size = New System.Drawing.Size(49, 17)
        Me.lblClassAverage.TabIndex = 9
        Me.lblClassAverage.Text = "0 / 100"
        '
        'lblFinalProjectScore
        '
        Me.lblFinalProjectScore.AutoSize = True
        Me.lblFinalProjectScore.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalProjectScore.Location = New System.Drawing.Point(215, 95)
        Me.lblFinalProjectScore.Name = "lblFinalProjectScore"
        Me.lblFinalProjectScore.Size = New System.Drawing.Size(49, 17)
        Me.lblFinalProjectScore.TabIndex = 7
        Me.lblFinalProjectScore.Text = "0 / 100"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(17, 95)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(122, 17)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Final Project Score :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(17, 128)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(134, 17)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Class Average Score :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(17, 60)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(134, 17)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Assignment Average :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(17, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 17)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Forum Average :"
        '
        'lblForumAverage
        '
        Me.lblForumAverage.AutoSize = True
        Me.lblForumAverage.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForumAverage.Location = New System.Drawing.Point(215, 26)
        Me.lblForumAverage.Name = "lblForumAverage"
        Me.lblForumAverage.Size = New System.Drawing.Size(49, 17)
        Me.lblForumAverage.TabIndex = 3
        Me.lblForumAverage.Text = "0 / 100"
        '
        'lblAssignmentAverage
        '
        Me.lblAssignmentAverage.AutoSize = True
        Me.lblAssignmentAverage.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignmentAverage.Location = New System.Drawing.Point(215, 60)
        Me.lblAssignmentAverage.Name = "lblAssignmentAverage"
        Me.lblAssignmentAverage.Size = New System.Drawing.Size(49, 17)
        Me.lblAssignmentAverage.TabIndex = 1
        Me.lblAssignmentAverage.Text = "0 / 100"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(20, 206)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(119, 30)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate &Grade"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnFinalScore)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 279)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(251, 100)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Enter The Score for the Final Project"
        '
        'btnFinalScore
        '
        Me.btnFinalScore.Location = New System.Drawing.Point(9, 39)
        Me.btnFinalScore.Name = "btnFinalScore"
        Me.btnFinalScore.Size = New System.Drawing.Size(174, 36)
        Me.btnFinalScore.TabIndex = 0
        Me.btnFinalScore.Text = "Enter &Final Project Score"
        Me.btnFinalScore.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(332, 33)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 17)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Name :"
        '
        'lblNameContainer
        '
        Me.lblNameContainer.AutoSize = True
        Me.lblNameContainer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameContainer.Location = New System.Drawing.Point(388, 33)
        Me.lblNameContainer.Name = "lblNameContainer"
        Me.lblNameContainer.Size = New System.Drawing.Size(47, 17)
        Me.lblNameContainer.TabIndex = 7
        Me.lblNameContainer.Text = "Name "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnPrint)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 416)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(251, 96)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Print Form"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(9, 34)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(141, 36)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "&Print Report Card"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Database51DataSet
        '


        '
        'GradeBookBindingSource
        '
        
        '
        'GradeBookTableAdapter
        '

        '
        'TableAdapterManager
        '
        

        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(313, 206)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 601)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lblNameContainer)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmMain"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)

        CType(Me.GradeBookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database51DataSet As Deshner_FinalProject.My.MySettings
    Friend WithEvents GradeBookBindingSource As System.Windows.Forms.BindingSource


    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblWeek5Assignment As System.Windows.Forms.Label
    Friend WithEvents lblWeek4Assignment As System.Windows.Forms.Label
    Friend WithEvents lblWeek3Assignment As System.Windows.Forms.Label
    Friend WithEvents lblWeek2Assignment As System.Windows.Forms.Label
    Friend WithEvents lblWeek1Assignment As System.Windows.Forms.Label
    Friend WithEvents lblWeek1Forum As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblWeek2Forum As System.Windows.Forms.Label
    Friend WithEvents lblWeek3Forum As System.Windows.Forms.Label
    Friend WithEvents lblWeek4Forum As System.Windows.Forms.Label
    Friend WithEvents lblWeek5Forum As System.Windows.Forms.Label
    Friend WithEvents lblWeek6Forum As System.Windows.Forms.Label
    Friend WithEvents lblWeek7Forum As System.Windows.Forms.Label
    Friend WithEvents lblWeek8Forum As System.Windows.Forms.Label
    Friend WithEvents lblWeek6Assignment As System.Windows.Forms.Label
    Friend WithEvents lblWeek7Assignment As System.Windows.Forms.Label
    Friend WithEvents lblWeek8Assignment As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cobWeeks As System.Windows.Forms.ComboBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtAssignmentScore As System.Windows.Forms.TextBox
    Friend WithEvents txtForumScore As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLetterGrade As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblClassAverage As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblFinalProjectScore As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblForumAverage As System.Windows.Forms.Label
    Friend WithEvents lblAssignmentAverage As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFinalScore As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblNameContainer As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
