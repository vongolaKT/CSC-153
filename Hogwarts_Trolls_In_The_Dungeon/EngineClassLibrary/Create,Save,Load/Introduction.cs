using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClassLibrary.Create_Save_Load
{
    public class Introduction
    {
        public static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"                  __  __                                            __");
            Console.WriteLine(@"                 /\ \/\ \                                          /\ \__");
            Console.WriteLine(@"                 \ \ \_\ \    ___     __   __  __  __    __    _ __\ \ ,_\   ____  __");
            Console.WriteLine(@"                  \ \  _  \  / __`\ /'_ `\/\ \/\ \/\ \ /'__`\ /\`'__\ \ \/  /',__\/\_\");
            Console.WriteLine(@"                   \ \ \ \ \/\ \L\ /\ \L\ \ \ \_/ \_/ /\ \L\.\\ \ \/ \ \ \_/\__, `\/_/_");
            Console.WriteLine(@"                    \ \_\ \_\ \____\ \____ \ \___x___/\ \__/.\_\ \_\  \ \__\/\____/ /\_\");
            Console.WriteLine(@"                     \/_/\/_/\/___/ \/___L\ \/__//__/  \/__/\/_/\/_/   \/__/\/___/  \/_/");
            Console.WriteLine(@" ______           ___   ___           /\____/             __    __                  ____"); 
            Console.WriteLine(@"/\__  _\         /\_ \ /\_ \          \_/__/_            /\ \__/\ \                /\  _`\");
            Console.WriteLine(@"\/_/\ \/ _ __  __\//\ \\//\ \     ____    /\_\    ___    \ \ ,_\ \ \___      __    \ \ \/\ \  __  __   ___      __      __    ___    ___");
            Console.WriteLine(@"   \ \ \/\`'__/ __`\ \ \ \ \ \   /',__\   \/\ \ /' _ `\   \ \ \/\ \  _ `\  /'__`\   \ \ \ \ \/\ \/\ \/' _ `\  /'_ `\  /'__`\ / __`\/' _ `\");
            Console.WriteLine(@"    \ \ \ \ \/\ \L\ \_\ \_\_\ \_/\__, `\   \ \ \/\ \/\ \   \ \ \_\ \ \ \ \/\  __/    \ \ \_\ \ \ \_\ /\ \/\ \/\ \L\ \/\  __//\ \L\ /\ \/\ \");
            Console.WriteLine(@"     \ \_\ \_\ \____/\____/\____\/\____/    \ \_\ \_\ \_\   \ \__\\ \_\ \_\ \____\    \ \____/\ \____\ \_\ \_\ \____ \ \____\ \____\ \_\ \_\");
            Console.WriteLine(@"      \/_/\/_/\/___/\/____\/____/\/___/      \/_/\/_/\/_/    \/__/ \/_/\/_/\/____/     \/___/  \/___/ \/_/\/_/\/___L\ \/____/\/___/ \/_/\/_/");
            Console.WriteLine(@"                                                                                                                /\____/");
            Console.WriteLine(@"                                                                                                                \_/__/");
            Console.WriteLine(@"--------------------------------------------------------------------------------------------------------------------------------------------");
            Console.ResetColor();

            DetermineNewPlayer.NewPlayer();
        }
    }
}
