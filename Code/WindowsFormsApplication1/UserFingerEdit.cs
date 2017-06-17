using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApplication1.Base;
using posb = PosBusiness;

namespace WindowsFormsApplication1
{
    public partial class UserFingerEdit : Form
    {
        #region Memebers

        private int? Id = null;

        public string UserName { get; set; }

        public List<posb.Finger> Fingers { get; set; }

        public int EnrolledFingerMask { get; set; }

        #endregion

        #region Builder

        public UserFingerEdit(int? Id)
        {
            InitializeComponent();

            //this.Fingers = new List<posb.Finger>();
            //this.Id = Id;
        
            //var User = new posb.User
            //{
            //    Id = this.Id
            //};

            //this.Fingers = User.GetFingers();

            //if (this.Fingers.Count.Equals(4))
            //{
            //    this.EnrollmentControl.EnrolledFingerMask = 106;
            //}
            //else
            //{
            //    this.Fingers.Clear();

            //    this.Fingers.Add(new posb.Finger { FingerMask = 1, IsValid = false });
            //    this.Fingers.Add(new posb.Finger { FingerMask = 2, IsValid = false });
            //    this.Fingers.Add(new posb.Finger { FingerMask = 7, IsValid = false });
            //    this.Fingers.Add(new posb.Finger { FingerMask = 9, IsValid = false });
            //}

            //this.CheckEnRoll();
        }

        #endregion

        #region Methods

        private bool IsValidEnRoll()
        {
            return this.Fingers.FindAll(p => p.IsValid.Equals(true)).Count.Equals(4);
        }

        private void CheckEnRoll()
        {
            this.btnAccept.Enabled = this.IsValidEnRoll();
        }

        #endregion

        private void Habitant_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void EnrollmentControl_OnEnroll(object Control, int FingerMask, DPFP.Template Template, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            if (FingerMask != 1 && FingerMask != 2 && FingerMask != 7 && FingerMask != 9)
            {
                //new AlertEnRoll().ShowDialog();

                if (this.IsValidEnRoll())
                    EnrollmentControl.EnrolledFingerMask = 106;
                else
                    EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure;
            }
            else
            {
                var finger = new posb.Finger();

                finger = this.Fingers.Find(p => p.FingerMask.Equals(FingerMask));

                finger.IsValid = true;
                finger.Data = Template.Bytes;
            }

            this.CheckEnRoll();
        }

        private void EnrollmentControl_Load(object sender, EventArgs e)
        {

        }
    }
}
