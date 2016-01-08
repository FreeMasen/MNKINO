using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MNKINO.Models
{
    public class MnkinoContextSeedData
    {
        private MnkinoContext _context;

        public MnkinoContextSeedData(MnkinoContext context)
        {
            _context = context;
        }

        public void EnsureSeedData()
        {
            if (!_context.Screenings.Any())
            {
                var orange = new Screening()
                {
                    MysteryMeat = new Uri("http://www.vimeo.com/mnkino"),
                    Number = 1,
                    Theme = "Orange",
                    Videos = new List<Video>()
                    {
                        new Video()
                        {
                            Author = "Lindasy Borgerson",
                            OnlineHome = new Uri("https://vimeo.com/5762591"),
                            Title = "MNKINO ORANGE"
                        },

                        new Video()
                        {
                            Author = "Chris Hontos",
                            OnlineHome = new Uri("https://vimeo.com/7737407"),
                            Title = "Now We've Got It"
                        },

                        new Video()
                        {
                            Author = "Michael Eckblad",
                            OnlineHome = new Uri("https://vimeo.com/7738630"),
                            Title = "untitled (MNKINO #1)"
                        },

                        new Video()
                        {
                            Author = "Nicholas Knutson",
                            OnlineHome = new Uri("#"),
                            Title = "Mosh Pit BBQ"
                        },

                        new Video()
                        {
                            Author = "Andy Dayton",
                            OnlineHome = new Uri("#"),
                            Title = "egnaro"
                        }
                    }
                };

                _context.Screenings.Add(orange);
                _context.Videos.AddRange(orange.Videos);

                var onOff = new Screening()
                {
                    MysteryMeat = new Uri("#"),
                    Number = 2,
                    Theme = "On Off",
                    Videos = new List<Video>()
                    {
                        new Video()
                        {
                            Author = "Michael Eckblad",
                            OnlineHome = new Uri(""),
                            Title = "MNKINO2 (On Milwaukee)"
                        },

                        new Video()
                        {
                            Author = "Lindsey Borgerson",
                            OnlineHome = new Uri("https://vimeo.com/7740373"),
                            Title = "Fliptastik"
                        },

                        new Video()
                        {
                            Author = "Nicholas Knutson",
                            OnlineHome = new Uri(""),
                            Title = "On/Off-Inactive/Bodies"
                        },

                        new Video()
                        {
                            Author = "Paul Rolfes",
                            OnlineHome = new Uri("https://vimeo.com/7743535"),
                            Title = "Down e Out"
                        },

                        new Video()
                        {
                            Author = "Andy Dayton",
                            OnlineHome = new Uri("https://vimeo.com/7739826"),
                            Title = "Summerwork"
                        },

                        new Video()
                        {
                            Author = "Erica Edwardson",
                            OnlineHome = new Uri("https://vimeo.com/7741859"),
                            Title = "ON / OFF"
                        },

                        new Video()
                        {
                            Author = "Jack Kentala",
                            OnlineHome = new Uri(""),
                            Title = "ON / OFF"
                        },

                        new Video()
                        {
                            Author = "Chris Hontos",
                            OnlineHome = new Uri(""),
                            Title = "Now We've Got It"
                        },

                        new Video()
                        {
                            Author = "Ariel Kitch",
                            OnlineHome = new Uri(""),
                            Title = "Oanh/Off"
                        },

                        new Video()
                        {
                            Author = "Zach Zierden",
                            OnlineHome = new Uri("https://vimeo.com/7739254"),
                            Title = "Vulcano"
                        }
                    }
                };

                _context.Screenings.Add(onOff);
                _context.Videos.AddRange(onOff.Videos);

                var transparency = new Screening()
                {
                    MysteryMeat = new Uri("#"),
                    Number = 3,
                    Theme = "Transparency",
                    Videos = new List<Video>()
                    {
                        new Video()
                        {
                            Author = "Jack Kentala",
                            OnlineHome = new Uri(""),
                            Title = "Transparency"
                        },

                        new Video()
                        {
                            Author = "Lindsey Borgerson",
                            OnlineHome = new Uri(""),
                            Title = "Transparent 'C'"
                        },

                        new Video()
                        {
                            Author = "Nicholas Schrader",
                            OnlineHome = new Uri(""),
                            Title = "Nothing"
                        },

                        new Video()
                        {
                            Author = "Nicholas Knutson",
                            OnlineHome = new Uri(""),
                            Title = "Transparency - MEGACHURCH"
                        },

                        new Video()
                        {
                            Author = "Andy Dayton",
                            OnlineHome = new Uri(""),
                            Title = "Paradise"
                        },

                        new Video()
                        {
                            Author = "Zach Zierden & Eli Krenik",
                            OnlineHome = new Uri(""),
                            Title = "Ghost Go Good"
                        }
                    }
                };
                _context.Screenings.Add(transparency);
                _context.Videos.AddRange(transparency.Videos);

                var repeatRepeat = new Screening()
                {
                    MysteryMeat = new Uri(""),
                    Number = 4,
                    Theme = "Repeat Repeat",
                    Videos = new List<Video>()
                    {
                     new Video()
                        {
                            Author = "Jack Kentala",
                            OnlineHome = new Uri(""),
                            Title = "Repeat, Or: Deep Thoughts By Rinna Broman"
                        },

                        new Video()
                        {
                            Author = "Lindsey Borgerson",
                            OnlineHome = new Uri(""),
                            Title = "Repeat: A Trilogy"
                        },

                        new Video()
                        {
                            Author = "Ariel Kitch & Andy Dayton",
                            OnlineHome = new Uri("https://vimeo.com/7747269"),
                            Title = "12.25.1971"
                        },

                        new Video()
                        {
                            Author = "Hal Schuler",
                            OnlineHome = new Uri(""),
                            Title = "Freaky Deeky: Reapeatz"
                        },

                        new Video()
                        {
                            Author = "Erica Edwardson",
                            OnlineHome = new Uri(""),
                            Title = "Around the World"
                        },

                        new Video()
                        {
                            Author = "Michael Eckblad & Candice Heberer",
                            OnlineHome = new Uri(""),
                            Title = "MNKINO4 (Untitled)"
                        },

                        new Video()
                        {
                            Author = "Brady Clark",
                            OnlineHome = new Uri(""),
                            Title = "Zzzzz"
                        }
                    }
                };

                _context.Screenings.Add(repeatRepeat);
                _context.Videos.AddRange(repeatRepeat.Videos);

                var CutCopyPaste = new Screening()
                {
                    MysteryMeat = new Uri(""),
                    Number = 5,
                    Theme = $"Cut/Copy/Paste",
                    Videos = new List<Video>()
                    {
                     new Video()
                        {
                            Author = "Peter Kirschmann & Oanh Vu",
                            OnlineHome = new Uri(""),
                            Title = "Rock, Paper, Scissors!"
                        },

                        new Video()
                        {
                            Author = "Ken R. Koense",
                            OnlineHome = new Uri(""),
                            Title = "Chance: Ode to John Cage"
                        },

                        new Video()
                        {
                            Author = "Jack Kentala",
                            OnlineHome = new Uri(""),
                            Title = "Cut Copy Paste, Or: The Cop Out (I'm So Sorry)"
                        },

                        new Video()
                        {
                            Author = "Lindsey Borgerson",
                            OnlineHome = new Uri(""),
                            Title = "Baby Got Sh-Boom"
                        },

                        new Video()
                        {
                            Author = "Andy Dayton",
                            OnlineHome = new Uri(""),
                            Title = "November"
                        },

                        new Video()
                        {
                            Author = "Nicholas Knutson",
                            OnlineHome = new Uri(""),
                            Title = "Rythm and Motion Study I"
                        },

                        new Video()
                        {
                            Author = "John Akre",
                            OnlineHome = new Uri(""),
                            Title = "Cut Copy Taste Torture"
                        }
                    }
                };

                _context.Screenings.Add(CutCopyPaste);
                _context.Videos.AddRange(CutCopyPaste.Videos);

                var Nonfiction = new Screening()
                {
                    MysteryMeat = new Uri(""),
                    Number = 5,
                    Theme = "Non-fiction",
                    Videos = new List<Video>()
                    {
                     new Video()
                        {
                            Author = "Jack Kentala",
                            OnlineHome = new Uri(""),
                            Title = "The Archetapes Vol. I: Filmmaking and Film-Aching"
                        },

                        new Video()
                        {
                            Author = "Ken R. Koense",
                            OnlineHome = new Uri(""),
                            Title = "Chance: Ode to John Cage"
                        },

                        new Video()
                        {
                            Author = "Lindsey Borgerson",
                            OnlineHome = new Uri(""),
                            Title = "Gazelles"
                        },

                        new Video()
                        {
                            Author = "Dustin Lundebrek",
                            OnlineHome = new Uri(""),
                            Title = "Or Best Offer"
                        },

                        new Video()
                        {
                            Author = "Andy Dayton",
                            OnlineHome = new Uri(""),
                            Title = "This Old Cabin"
                        },

                        new Video()
                        {
                            Author = "Nicholas Knutson",
                            OnlineHome = new Uri(""),
                            Title = "untitled"
                        }
                    }
                };

                _context.Screenings.Add(Nonfiction);
                _context.Videos.AddRange(Nonfiction.Videos);
            }
        }
    }
}
