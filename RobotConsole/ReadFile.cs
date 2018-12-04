using System;
using System.Collections.Generic;
using System.IO;

namespace RobotConsole
{
    /// <summary>
    ///  Static Class for read command file
    /// </summary>
    public static class ReadFile
    {

        /// <summary>
        /// Gets the specified arguments.
        /// </summary>
        /// <param name="arguments">The arguments.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public static List<string> Get(string[] arguments)
        {
            var line = string.Empty;
            var commandList = new List<string>();

            try
            {
                if (arguments != null && arguments.Length > 0)
                {
                    var file = new StreamReader(arguments[0]);

                    while ((line = file.ReadLine()) != null)
                    {
                        commandList.Add(line);
                    }

                    file.Close();

                    return commandList;
                }
                return new List<string>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }


}
