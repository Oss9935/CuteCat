﻿namespace CuteCat
{
     partial class Form1
     {
          /// <summary>
          /// 필수 디자이너 변수입니다.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// 사용 중인 모든 리소스를 정리합니다.
          /// </summary>
          /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form 디자이너에서 생성한 코드

          /// <summary>
          /// 디자이너 지원에 필요한 메서드입니다. 
          /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
          /// </summary>
          private void InitializeComponent()
          {
               this.components = new System.ComponentModel.Container();
               this.CatScreen1 = new System.Windows.Forms.Label();
               this.Play = new System.Windows.Forms.Button();
               this.Feed = new System.Windows.Forms.Button();
               this.CatTimer = new System.Windows.Forms.Timer(this.components);
               this.SuspendLayout();
               // 
               // CatScreen1
               // 
               this.CatScreen1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.CatScreen1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
               this.CatScreen1.Location = new System.Drawing.Point(12, 41);
               this.CatScreen1.Name = "CatScreen1";
               this.CatScreen1.Size = new System.Drawing.Size(369, 46);
               this.CatScreen1.TabIndex = 0;
               this.CatScreen1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               // 
               // Play
               // 
               this.Play.Location = new System.Drawing.Point(12, 125);
               this.Play.Name = "Play";
               this.Play.Size = new System.Drawing.Size(51, 49);
               this.Play.TabIndex = 1;
               this.Play.Text = "Play";
               this.Play.UseVisualStyleBackColor = true;
               this.Play.Click += new System.EventHandler(this.Play_Click);
               // 
               // Feed
               // 
               this.Feed.Location = new System.Drawing.Point(79, 125);
               this.Feed.Name = "Feed";
               this.Feed.Size = new System.Drawing.Size(51, 49);
               this.Feed.TabIndex = 2;
               this.Feed.Text = "Feed";
               this.Feed.UseVisualStyleBackColor = true;
               this.Feed.Click += new System.EventHandler(this.Feed_Click);
               // 
               // CatTimer
               // 
               this.CatTimer.Enabled = true;
               this.CatTimer.Interval = 3000;
               this.CatTimer.Tick += new System.EventHandler(this.timer1_Tick);
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(406, 225);
               this.Controls.Add(this.Feed);
               this.Controls.Add(this.Play);
               this.Controls.Add(this.CatScreen1);
               this.Name = "Form1";
               this.Text = "Form1";
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Label CatScreen1;
          private System.Windows.Forms.Button Play;
          private System.Windows.Forms.Button Feed;
          private System.Windows.Forms.Timer CatTimer;
     }
}

