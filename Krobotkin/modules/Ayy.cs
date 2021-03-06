﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;

namespace KrobotkinDiscord.Modules {
    class Ayy : Module {
        public override async void ParseMessageAsync(Channel channel, Message message) {
            if (message.Text.ToLower() == "ayy") {
                if (Config.INSTANCE.GetPermissionLevel(message.User, message.Server) > 0) {
                    await channel.SendIsTyping();
                    await channel.SendFile("resources/lmao.gif");
                }
            }
        }
    }
}
