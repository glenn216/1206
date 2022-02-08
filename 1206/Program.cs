#region MIT License
// Copyright (c) 2022 Glenn Alon
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion

// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

// Zoom Executable File Directory
var zoomFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Zoom\bin\Zoom.exe");
var zoomDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Zoom\bin");

// Homeroom
const string HR     =     @"zoommtg://zoom.us/join?action=join&confno=7815334291&pwd=QWxVd2NMQTZ4aTdSNmoyQzMrUVMvQT09";

#region SetA
const string MIL    =     @"zoommtg://zoom.us/join?action=join&confno=81703542193";
const string GP6    =     @"zoommtg://zoom.us/join?action=join&confno=72915690092&pwd=dldxQ2J2L09PUTZJUTQwVTlsL05sZz09";
const string CPAR   =     @"zoommtg://zoom.us/join?action=join&confno=3204120850&pwd=bHV2OU5XeFNNZW9kS0d1L1Q1V2pEUT09";
const string UCSP   =     @"zoommtg://zoom.us/join?action=join&confno=78044635773&pwd=LxMFikP5nuXPRTnfFCntwUlRfSS5-i.1";
#endregion

#region SetB
const string PEH4   =     @"zoommtg://zoom.us/join?action=join&confno=75137764227&pwd=dFlMaU9FcU1KY1ZLb1VJQXVzU1RjZz09";
const string GC2    =     @"zoommtg://zoom.us/join?action=join&confno=6780299108&pwd=N2tTbnpEZXNXUFFmWjB5K3RTeCtZZz09";
const string GB2    =     @"zoommtg://zoom.us/join?action=join&confno=2709602484&pwd=eTR3Sm8rQ1VYdHFtbE1lc2dIZGVJUT09";
const string EAPP   =     @"zoommtg://zoom.us/join?action=join&confno=87035610843&pwd=cjRYaS9PeG1aUmM2cFRjY2c2SDlJUT09";
#endregion

string input;
try
{
    bool primaryHeader = true;
    do
    {
        Console.Clear();
        Console.WriteLine("Enter the number from the selection.");
        Console.WriteLine("     [0] Set A Subjects");
        Console.WriteLine("     [1] Set B Subjects");
        Console.Write("Input: ");
        input = Console.ReadLine();

        switch (input)
        {
            case "0":
                {
                    primaryHeader = false;
                    bool secondaryHeader = true;
                    do
                    {
                        Console.Clear();

                        Console.WriteLine("Enter the number from the selection.");
                        Console.WriteLine("     [0] Homeroom");
                        Console.WriteLine("     [1] Media and Information Literacy");
                        Console.WriteLine("     [2] General Physics 2");
                        Console.WriteLine("     [3] Contemporary Philippine Arts from the Regions");
                        Console.WriteLine("     [4] Understanding Culture Society and Politics");
                        Console.WriteLine("     [5] Exit");
                        Console.Write("Input: ");
                        input = Console.ReadLine();
                        switch (input)
                        {
                            case "0":
                                LaunchZoom(HR);
                                break;
                            case "1":
                                LaunchZoom(MIL);
                                break;
                            case "2":
                                LaunchZoom(GP6);
                                break;
                            case "3":
                                LaunchZoom(CPAR);
                                break;
                            case "4":
                                LaunchZoom(UCSP);
                                break;
                            case "5":
                                Environment.Exit(0);
                                break;
                        }
                    } while (secondaryHeader = true);
                    break;
                }

            case "1":
                {
                    primaryHeader = false;
                    bool secondaryHeader = true;
                    do
                    {
                        Console.Clear();

                        Console.WriteLine("Enter the number from the selection.");
                        Console.WriteLine("     [0] Homeroom");
                        Console.WriteLine("     [1] Physical Education and Health 4");
                        Console.WriteLine("     [2] General Chemistry 2");
                        Console.WriteLine("     [3] General Biology 2");
                        Console.WriteLine("     [4] English for Academic and Professional Purposes");
                        Console.WriteLine("     [5] Exit");
                        Console.Write("Input: ");
                        input = Console.ReadLine();
                        switch (input)
                        {
                            case "0":
                                LaunchZoom(HR);
                                break;
                            case "1":
                                LaunchZoom(PEH4);
                                break;
                            case "2":
                                LaunchZoom(GC2);
                                break;
                            case "3":
                                LaunchZoom(GB2);
                                break;
                            case "4":
                                LaunchZoom(EAPP);
                                break;
                            case "5":
                                Environment.Exit(0);
                                break;
                        }
                    } while (secondaryHeader = true);
                    break;
                }
        }
    } while (primaryHeader = true);
}
catch (Exception e)
{

}

void LaunchZoom(string link) => Process.Start(new ProcessStartInfo{
    FileName = zoomFile, 
    Arguments = $"--url={link}", 
    WorkingDirectory = zoomDirectory
});
