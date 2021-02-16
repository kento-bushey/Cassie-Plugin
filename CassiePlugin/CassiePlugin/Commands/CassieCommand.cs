using System;
using CommandSystem;
using RemoteAdmin;
using Exiled.API.Features;
using Exiled.API.Enums;
using Exiled.Permissions.Extensions;

namespace CassiePlugin.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class CassieCommand : ICommand
    {
        public string Command { get; } = "cbc";

        public string[] Aliases { get; } = {"Cassiebc"};

        public string Description { get; } =  "Cassie broadcast." ;

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!((CommandSender)sender).CheckPermission("CassiePlugin.cassie"))
            {
                response = "You do not have permission to use this command";
                return false;
            }
            if (arguments.Count != 2)
            {
                response = "Usage: cbc (plurality 0-1) (zone 1-4)";
                return false;
            }
            if (!(arguments.At(0).Equals("0")) && !(arguments.At(0).Equals("1")))
            {
                response = "Usage: cbc (plurality 0-1) (zone 1-4)";
                return false;
            }
            if (!(arguments.At(1).Equals("1")) && !(arguments.At(1).Equals("2")) && !(arguments.At(1).Equals("3")) && !(arguments.At(1).Equals("4")))
            {
                response = "Usage: cbc (plurality 0-1) (zone 1-4)";
                return false;
            }
            Cassie.Message("ATTENTION . LAST TARGET"+ getPlural(arguments.At(0)) +" "+ getZone(arguments.At(1)));
            response = "Cassie broadcast sent. ";
            return true;
            
        }
        private string getPlural(string num)
        {
            if (num.Equals("1"))
            {
                return "S";
            }
            return "";
        }
        private string getZone(string num)
        {
            if (num.Equals("1"))
            {
                return "IN LIGHT CONTAINMENT";
            }
            if (num.Equals("2"))
            {
                return "IN HEAVY CONTAINMENT";
            }
            if (num.Equals("3"))
            {
                return "IN ENTRANCE ZONE";
            }
            if (num.Equals("4"))
            {
                return "ON SURFACE";
            }
            return "";
        }
    }
}
