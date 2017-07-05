using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;

namespace MemeMachine
{
    class MyBot
    {
        DiscordClient discord;
        CommandService commands;

        Random rand;
        string[] respuestas;

        public MyBot()
        {
            rand = new Random();

            respuestas = new string[]
            {
                "si", "no", "tal vez", "chtm"
            };

            discord = new DiscordClient(x =>
            {
                x.LogLevel = LogSeverity.Info;
                x.LogHandler = Log;
            });

            discord.UsingCommands(x =>
            {
                x.PrefixChar = '!';
                x.AllowMentionPrefix = true;
            });

            commands = discord.GetService<CommandService>();

            //Chat Commands
            //message
            ayy();
            julio();
            daddy();
            normies();
            kahoot();
            navySeals();
            uvm();

            //text to speech
            dab();
            fu();
            xd();

            //randomizer
            ask();

            //conexion
            discord.ExecuteAndWait(async () =>
            {
                await discord.Connect("MzEyNjY1MTczMDUzOTMxNTIw.C_fs0g.O8cFvjRl89V2dbyFYFk-IBRSl5Y", TokenType.Bot);
            });
        }

        //La UVM no esta jodida
        private void uvm()
        {
            commands.CreateCommand("UVM")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("No esta jodida");
                });
        }

        //spank me daddy
        private void daddy()
        {
            commands.CreateCommand("spankmedaddy")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("Oh yeah Mr Krabs");
                });
        }

        //que dijiste julio?
        private void julio()
        {
            commands.CreateCommand("julio")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("AGUACATEEEE!");
                });
        }

        //kahoot yayaya
        private void kahoot()
        {
            commands.CreateCommand("kahoot")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("yayaya");
                });
        }

        //ayy lmao
        private void ayy()
        {
            commands.CreateCommand("ayy")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("lmao");
                });
        }

        //dab text to speech
        private void dab()
        {
            commands.CreateCommand("dab")
                .Do(async (e) =>
                {
                    await e.Channel.SendTTSMessage("dab");
                });
        }

        //Text to speech what the fuck mate
        private void fu()
        {
            commands.CreateCommand("fu")
                .Do(async (e) =>
                {
                    await e.Channel.SendTTSMessage("What the FUCK mate? MAN YOU ARE SO FUCKING WITH NEA. DONT TRY TO MAKE HER YOUR SIDE CHICK. SHE IS INNOCENT AND YOU'VE CHEATED ON HER. DONT MANUPULATE HER INTO BLOCKING ME");
                });
        }

        //Text to speech
        private void xd()
        {
            commands.CreateCommand("xd")
                .Do(async (e) =>
                {
                    await e.Channel.SendTTSMessage("xd");
                });
        }

        //El oraCULO
        private void ask()
        {
            commands.CreateCommand("oraCulo")
                .Do(async (e) =>
                {
                    int memeIndex = rand.Next(respuestas.Length);
                    string ans = respuestas[memeIndex];
                    await e.Channel.SendMessage(ans);
                });
        }

        //navy seals copypasta
        private void navySeals()
        {
            commands.CreateCommand("navyseals")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("What the fuck did you just fucking say about me, you little bitch? " +
                        "I’ll have you know I graduated top of my class in the Navy Seals, and I’ve been involved in nu" +
                        "merous secret raids on Al-Quaeda, and I have over 300 confirmed kills. I am trained in gorilla" +
                        " warfare and I’m the top sniper in the entire US armed forces. You are nothing to me but just " +
                        "another target. I will wipe you the fuck out with precision the likes of which has never been " +
                        "seen before on this Earth, mark my fucking words. You think you can get away with saying that " +
                        "shit to me over the Internet? Think again, fucker. As we speak I am contacting my secret netwo" +
                        "rk of spies across the USA and your IP is being traced right now so you better prepare for the" +
                        " storm, maggot. The storm that wipes out the pathetic little thing you call your life. You’re " +
                        "fucking dead, kid. I can be anywhere, anytime, and I can kill you in over seven hundred ways, " +
                        "and that’s just with my bare hands. Not only am I extensively trained in unarmed combat, but I" +
                        " have access to the entire arsenal of the United States Marine Corps and I will use it to its " +
                        "full extent to wipe your miserable ass off the face of the continent, you little shit. If only" +
                        " you could have known what unholy retribution your little “clever” comment was about to bring " +
                        "down upon you, maybe you would have held your fucking tongue. But you couldn’t, you didn’t, an" +
                        "d now you’re paying the price, you goddamn idiot. I will shit fury all over you and you will d" +
                        "rown in it. You’re fucking dead, kiddo.");
                });
        }

        //normies get out reee
        private void normies()
        {
            commands.CreateCommand("fuckingnormies")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("REEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
                        "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
                        "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
                        "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
                        "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
                        "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
                        "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
                        "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
                        "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
                        "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
                        "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
                        "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
                        "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
                        "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
                        "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
                        "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
                        "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
                        "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
                        "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
                        "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");
                });
        }

        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
