Namespace dxSample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.documentViewer1 = New DevExpress.XtraPrinting.Preview.DocumentViewer()
            Me.SuspendLayout()
            ' 
            ' documentViewer1
            ' 
            Me.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.documentViewer1.DocumentSource = GetType(dxSample.XtraReport1)
            Me.documentViewer1.IsMetric = False
            Me.documentViewer1.Location = New System.Drawing.Point(0, 0)
            Me.documentViewer1.Name = "documentViewer1"
            Me.documentViewer1.Size = New System.Drawing.Size(846, 659)
            Me.documentViewer1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(846, 659)
            Me.Controls.Add(Me.documentViewer1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private documentViewer1 As DevExpress.XtraPrinting.Preview.DocumentViewer
    End Class
End Namespace

