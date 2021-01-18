using AuditHistoryExtractor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditHistoryExtractor.Collections
{
    public static class AuditHistoryCollections
    {


        public static List<Operation> operations = new List<Operation>()
        {
            new Operation(1,"Create" ),
            new Operation(2,"Update" ),
            new Operation(3,"Delete" ),
            new Operation(4,"Access" ),
        };


        public static List<Operation> actions = new List<Operation>()
        {
            new Operation(0,"Unknown"),
            new Operation(1,"Create"),
            new Operation(2,"Update"),
            new Operation(3,"Delete"),
            new Operation(4,"Activate"),
            new Operation(5,"Deactivate"),
            new Operation(11,"Cascade"),
            new Operation(12,"Merge"),
            new Operation(13,"Assign"),
            new Operation(14,"Share"),
            new Operation(15,"Retrieve"),
            new Operation(16,"Close"),
            new Operation(17,"Cancel"),
            new Operation(18,"Complete"),
            new Operation(20,"Resolve"),
            new Operation(21,"Reopen"),
            new Operation(22,"Fulfill"),
            new Operation(23,"Paid"),
            new Operation(24,"Qualify"),
            new Operation(25,"Disqualify"),
            new Operation(26,"Submit"),
            new Operation(27,"Reject"),
            new Operation(28,"Approve"),
            new Operation(29,"Invoice"),
            new Operation(30,"Hold"),
            new Operation(31,"Add Member"),
            new Operation(32,"Remove Member"),
            new Operation(33,"Associate Entities"),
            new Operation(34,"Disassociate Entities"),
            new Operation(35,"Add Members"),
            new Operation(36,"Remove Members"),
            new Operation(37,"Add Item"),
            new Operation(38,"Remove Item"),
            new Operation(39,"Add Substitute"),
            new Operation(40,"Remove Substitute"),
            new Operation(41,"Set State"),
            new Operation(42,"Renew"),
            new Operation(43,"Revise"),
            new Operation(44,"Win"),
            new Operation(45,"Lose"),
            new Operation(46,"Internal Processing"),
            new Operation(47,"Reschedule"),
            new Operation(48,"Modify Share"),
            new Operation(49,"Unshare"),
            new Operation(50,"Book"),
            new Operation(51,"Generate Quote From Opportunity"),
            new Operation(52,"Add To Queue"),
            new Operation(53,"Assign Role To Team"),
            new Operation(54,"Remove Role From Team"),
            new Operation(55,"Assign Role To User"),
            new Operation(56,"Remove Role From User"),
            new Operation(57,"Add Privileges to Role"),
            new Operation(58,"Remove Privileges From Role"),
            new Operation(59,"Replace Privileges In Role"),
            new Operation(60,"Import Mappings"),
            new Operation(61,"Clone"),
            new Operation(62,"Send Direct Email"),
            new Operation(63,"Enabled for organization"),
            new Operation(64,"User Access via Web"),
            new Operation(65,"User Access via Web Services"),
            new Operation(100,"Delete Entity"),
            new Operation(101,"Delete Attribute"),
            new Operation(102,"Audit Change at Entity Level"),
            new Operation(103,"Audit Change at Attribute Level"),
            new Operation(104,"Audit Change at Org Level"),
            new Operation(105,"Entity Audit Started"),
            new Operation(106,"Attribute Audit Started"),
            new Operation(107,"Audit Enabled"),
            new Operation(108,"Entity Audit Stopped"),
            new Operation(109,"Attribute Audit Stopped"),
            new Operation(110,"Audit Disabled"),
            new Operation(111,"Audit Log Deletion"),
            new Operation(112,"User Access Audit Started"),
            new Operation(113,"User Access Audit Stopped")
        };




    }
}
