﻿using System;
using System.Windows.Forms;

namespace Runner.IssueTracker
{
    public partial class InsertIssueView : Form, IInsertIssueView
    {
        private IInsertIssueController m_controller;

        public string IssueText
        {
            get { return txtIssue.Text; }
            set { txtIssue.Text = value; }
        }

        public InsertIssueView()
        {
            InitializeComponent();
        }

        public void SetController(IInsertIssueController controller)
        {
            m_controller = controller;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            m_controller.ConfirmSelection();
        }
    }

    public interface IInsertIssueView
    {
        void SetController(IInsertIssueController controller);
        DialogResult ShowDialog();
        void Close();
        string IssueText { get; set; }
    }
}