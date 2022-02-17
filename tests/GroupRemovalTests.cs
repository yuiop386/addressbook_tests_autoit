using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void TestGroupRemoval()
        {
            app.Groups.OpenGroupsDialogue();

            if (app.Groups.GetGroupList().Count <= 1)
            {
                app.Groups.CloseGroupsDialogue();
                app.Groups.Add(new GroupData("TGR_created"));
            }

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Remove(0);
            oldGroups.RemoveAt(0);

            List<GroupData> newGroups = app.Groups.GetGroupList();

            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
