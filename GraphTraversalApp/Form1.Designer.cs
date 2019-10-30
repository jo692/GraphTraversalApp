﻿using System;

namespace GraphTraversalApp
{
    partial class GraphTraversalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphTraversalForm));
            this.bfsButton = new System.Windows.Forms.Button();
            this.newGraphButton = new System.Windows.Forms.Button();
            this.dfsButton = new System.Windows.Forms.Button();
            this.resetGraphButton = new System.Windows.Forms.Button();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.graphPanel = new System.Windows.Forms.Panel();
            this.promptLabel = new System.Windows.Forms.Label();
            this.dijkstraButton = new System.Windows.Forms.Button();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bfsButton
            // 
            this.bfsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfsButton.Location = new System.Drawing.Point(198, 7);
            this.bfsButton.Name = "bfsButton";
            this.bfsButton.Size = new System.Drawing.Size(128, 39);
            this.bfsButton.TabIndex = 0;
            this.bfsButton.Text = "BFS";
            this.bfsButton.UseVisualStyleBackColor = true;
            this.bfsButton.Click += new System.EventHandler(this.BfsButtonClick);
            // 
            // newGraphButton
            // 
            this.newGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGraphButton.Location = new System.Drawing.Point(8, 7);
            this.newGraphButton.Name = "newGraphButton";
            this.newGraphButton.Size = new System.Drawing.Size(144, 39);
            this.newGraphButton.TabIndex = 1;
            this.newGraphButton.Text = "New Graph";
            this.newGraphButton.UseVisualStyleBackColor = true;
            this.newGraphButton.Click += new System.EventHandler(this.NewGraphButtonClick);
            // 
            // dfsButton
            // 
            this.dfsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dfsButton.Location = new System.Drawing.Point(466, 7);
            this.dfsButton.Name = "dfsButton";
            this.dfsButton.Size = new System.Drawing.Size(128, 39);
            this.dfsButton.TabIndex = 3;
            this.dfsButton.Text = "DFS";
            this.dfsButton.UseVisualStyleBackColor = true;
            this.dfsButton.Click += new System.EventHandler(this.DfsButtonClick);
            // 
            // resetGraphButton
            // 
            this.resetGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetGraphButton.Location = new System.Drawing.Point(639, 7);
            this.resetGraphButton.Name = "resetGraphButton";
            this.resetGraphButton.Size = new System.Drawing.Size(144, 39);
            this.resetGraphButton.TabIndex = 4;
            this.resetGraphButton.Text = "Reset Graph";
            this.resetGraphButton.UseVisualStyleBackColor = true;
            this.resetGraphButton.Click += new System.EventHandler(this.ResetGraphButtonClick);
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPanel.Controls.Add(this.dijkstraButton);
            this.buttonPanel.Controls.Add(this.dfsButton);
            this.buttonPanel.Controls.Add(this.bfsButton);
            this.buttonPanel.Controls.Add(this.resetGraphButton);
            this.buttonPanel.Controls.Add(this.newGraphButton);
            this.buttonPanel.Location = new System.Drawing.Point(5, 392);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(790, 52);
            this.buttonPanel.TabIndex = 5;
            // 
            // graphPanel
            // 
            this.graphPanel.BackColor = System.Drawing.SystemColors.Window;
            this.graphPanel.Location = new System.Drawing.Point(13, 35);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(775, 351);
            this.graphPanel.TabIndex = 6;
            this.graphPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphPanelPaintGraph);
            this.graphPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GraphPanelMouseClick);
            // 
            // promptLabel
            // 
            this.promptLabel.BackColor = System.Drawing.Color.Transparent;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.promptLabel.Location = new System.Drawing.Point(16, 0);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(772, 32);
            this.promptLabel.TabIndex = 7;
            this.promptLabel.Text = "Click \'New Graph\' to get started";
            this.promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dijkstraButton
            // 
            this.dijkstraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dijkstraButton.Location = new System.Drawing.Point(332, 7);
            this.dijkstraButton.Name = "dijkstraButton";
            this.dijkstraButton.Size = new System.Drawing.Size(128, 39);
            this.dijkstraButton.TabIndex = 5;
            this.dijkstraButton.Text = "Dijkstra";
            this.dijkstraButton.UseVisualStyleBackColor = true;
            this.dijkstraButton.Click += new System.EventHandler(this.DijkstraButtonClick);
            // 
            // GraphTraversalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.graphPanel);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.buttonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GraphTraversalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph Traversal App";
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bfsButton;
        private System.Windows.Forms.Button newGraphButton;
        private System.Windows.Forms.Button dfsButton;
        private System.Windows.Forms.Button resetGraphButton;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Button dijkstraButton;
    }
}

