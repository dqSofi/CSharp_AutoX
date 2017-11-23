using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace AddressbookAutoIt
{
    public class GroupHelper:HelperBase
    {
        public static string GROUPWINTITLE = "Group Editor";
        public GroupHelper(ApplicationManager manager) : base(manager) { }

        public List<GroupData> GetGroupList()
        {
            return new List<GroupData>();
        }

        public void Add(GroupData newGroup)
        {
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d512");
            aux.WinWait(GROUPWINTITLE);
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d5");
            aux.Send(newGroup.Name);
            aux.Send("{ENTER}");
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d54");
        }
    }
}