using System;
using System.Collections.Generic;
using System.Text;

namespace DemonStar.FnordLib
{
    public class Fnorder
    {
        // Define arrays for each part of speech 
        private String[] adjectives = {
            "23rd ", "acceptable ", "acrobatic ", "alien ", "amiable ",
            "amoeboid ", "ancient ", "arbitrary ", "atomic ", "avenging ",
            "awesome ", "balanced ", "besotted ", "best ", "black ", "blue ",
            "calculating ", "cast iron ", "cat-like ", "cautious ", "Chinese ",
            "cold ", "communist ", "corrupt ", "dead ", "deadly ", "dehydrated ",
            "disguised ", "dizzy ", "drug-crazed ", "drunken ", "easy ",
            "electric ", "embossed ", "enormous ", "expensive ", "explosive ",
            "extraterrestrial ", "ferocious ", "frozen ", "furry ", "gelatinous ",
            "glowing ", "gnarly ", "gold ", "granular ", "greedy ", "green ",
            "high ", "highest ", "hot ", "humming ", "illuminated ", "imitation ",
            "impotent ", "impudent ", "impulsive ", "indictable ", "innocent ",
            "insane ", "Japanese ", "lecherous ", "lizard-like ", "lovely ",
            "maniacal ", "mauve ", "medium-sized ", "morbid ", "most influential ",
            "mutant ", "naughty ", "nuclear ", "oily ", "oozing ", "opaque ",
            "opulent ", "orbital ", "persuasive ", "pickled ", "poor ",
            "pregnant ", "protozoan ", "puce ", "pulsating ", "purple ",
            "putrid ", "radical ", "radioactive ", "red ", "reformed ",
            "reincarnated ", "rubber ", "Russian ", "screaming ", "sexy ",
            "shiftless ", "shifty ", "Siamese ", "silver ", "sin-ridden ",
            "sinister ", "sizzling ", "skeptical ", "slack-producing ",
            "sleeping ", "slick ", "slime-dripping ", "slimy ", "slippery ",
            "sluggish ", "smoking ", "solid gold ", "splendid ", "squamous ",
            "stoned ", "sweet ", "temporary ", "throbbing ", "tin-plated ",
            "tiny ", "transient ", "treacherous ", "tubular ", "ugly ",
            "untouchable ", "user-friendly ", "user-serviceable ", "vacant ",
            "vacillating ", "vampiric ", "vibrant ", "virginal ", "vivid ",
            "wealthy ", "well-dressed ", "white ", "wimpy ", "worthless ",
            "young ","illegal ", "tax-free ", "drugged ", "polluted ",
            "flaming ", "diseased ", "agnostic ","anorexic ", "conquering ",
            "cosmic ", "dancing ", "dyslexic ", "frenzied ", "lumpy ", "musical ",
            "plump ", "perfectly ordinary ", "French ", "Martian ",
            "beautiful ", "broken ", "corruscating ", "enhanced ", "frightening ", 
            "horrific ", "mythical ", "rugose ", "upgraded "
            };

        private String[] names = {
            "007 ", "a dead relative ", "a long-lost uncle ","a dead rock star ",
            "Abdul Al-Azrad ", "Abraham Lincoln ", "Bill Gates ","Albert Einstein ",
            "Ali Baba ", "Aladdin ", "Batman ", "Buck Rogers ", "Bullwinkle ",
            "Captain Ahab ", "Captain America ", "Captain Kirk ", "Captain Nemo ",
            "Charlie Brown ", "Cthulhu ", "Dilbert ", "Darth Vader ", "Dave Letterman ",
            "Uncle Bob ", "Dracula ", "Elvis ", "Erik Bloodaxe ", "Evil Stevie ",
            "Fearless Leader ", "Flaming Carrot ", "George Lucas ", "Gerald Ford ", "Gandhi ",
            "Grandmother ", "Gumby ", "Hamlet ", "Han Solo ", "Hitler ", "Hulk Hogan ",
            "Hunter S. Thompson ", "Internal Security ", "Isaac Asimov ", "Jack the Ripper ",
            "Jimmy Carter ", "Johnny-B-Gud ", "Joseph Stalin ", "King Arthur ", "King Tut ",
            "Lex Luthor ", "Luke Skywalker ", "Michael Jordan ", "Mick Jagger ", "Mr. Bill ",
            "Mr. Ed ", "Mr. Science ", "Mr. Spock ", "Nelson Mandela ", "Nixon ", "Norman Bates ",
            "Obi-Wan Kenobi ", "Oliver North ", "Paul Newman ", "Perry Mason ", "Princess Leia ",
            "Rambo ", "Ringo ", "Robby the Robot ", "Robert Heinlein ", "Rocky ", "Roger Rabbit ",
            "Ronald Reagan ", "Scrooge ", "Sir Lancelot ", "Snoopy ", "Spiderman ", "Squad 23 ",
            "Steve ", "Steven Spielberg ", "Superman ", "the A.C.L.U. ", "The Computer ",
            "the Discordian ", "Sir Paul ", "the Hand ", "The Illuminati ", "the Joker ",
            "the Legion of Doom ","the ninja ", "the Secret Master ", "the Secret Service ",
            "the vice squad ", "Thor ", "Tiny Tim ", "Tweety-Bird ", "Uncle Duke ", "Weird Al ",
            "Winston Churchill ", "yo' mama ", "your brother ", "your evil twin ", "your father ",
            "your mother ", "your sister ", "Zaphod Beeblebrox ", "Zeus ", "Zonker ","Donovan's Brain ",
            "Jimmy Hoffa ","Tristero ","the Archdean ","Asmodeus ","Archangel Gabriel ", "Al-Qaeda ",
            "Angel ", "Arnold Schwarzenegger ", "Barry Bonds ", "Bill Clinton ", "Bill O'Reilly ",
            "Britney Spears ", "Bud Selig ", "Buffy ", "Captain Archer ", "Condoleeza Rice ",
            "Dick Cheney ", "Harry Potter ", "Harvey Birdman ", "Hillary Clinton ", "Jacques Chirac ",
            "Jay Leno ", "Joe Montana ", "John Ashcroft ", "Jon Stewart ", "Karl Rove ", "LeBron James ",
            "Neo ", "Osama bin-Laden ", "Peter Jackson ", "President Bartlett ", "President Bush ",
            "Saddam Hussein ", "Sponge Bob Square Pants ", "T'Pol ", "Tony Blair ", "the American Idol ",
            "the Bachelor ", "the Bachelorette ", "the Crocodile Hunter ", "the Dixie Chicks ",
            "the Powerpuff Girls "
            };

        private String[] places = {
            "(not available at your clearance) ", "Afghanistan ", "Alpha Centauri ",
            "Alpha Complex ", "Atlantis ", "Austin ", "Baghdad ", "Berkeley ", "Berlin ",
            "Buckingham Palace ", "Callahan's Place ", "Cheyenne Mountain ",
            "Chicago ", "Cyberworld ", "Dallas ", "Death Valley ", "Dime Box ",
            "Endsville ", "Gasoline Alley ", "Gotham City ", "headquarters ", "Hell ",
            "Hollywood ", "Hong Kong ", "Iran ", "Iraq ", "Israel ",
            "Joe's Bar and Grill ", "Kabul ", "Katmandu ", "Lake Geneva ", "Las Vegas ",
            "left field ", "Lithuania ", "London ", "Los Angeles ", "Main Street ",
            "Mars ", "Middle-earth ", "Mission Control ", "Mordor ", "Moscow ",
            "Munich ", "my back yard ", "Peking ", "Poland ",
            "San Francisco ", "Siberia ", "Sixth Street ", "SJ Games ",
            "Switzerland ", "Tel Aviv ", "the back forty ", "the Bastille ",
            "the bathroom ", "the best place possible ", "the brewery ",
            "the Bat Cave ", "the corner bar ", "the dentists' convention ",
            "the doghouse ", "the dumpster ", "the editorial department ",
            "the Empire State Building ", "the hackers' convention ",
            "the home of a trusted friend ", "the Hotel California ", 
            "the Last National Bank ", "the North Pole ", "the ocean ", 
            "the outback ", "the Phoenix Project ", "the river ", 
            "the same place as before ", "the service station ", "the South Pole ", 
            "the Super Bowl ", "the tavern ", "the toxic waste dump ", 
            "the U.S. Attorney's Office ", "the Vatican ", "the Watergate Hotel ", 
            "the White House ", "Toledo ", "Topeka ", "Uranus ", "Wall Street ", 
            "you-know-where ", "your place ", "Yrth ","the Death Star ",
            "beautiful downtown Burbank ", "Smallville ", "the Shire "
            };

        private String[] prepositions = {
            "assumes responsibility for ", "avoids servants of ",
            "deals with ", "elopes with ", "evades agents of ", "flees from ",
            "flees to ", "flies to ", "flies toward ", "goes for ", "goes to ",
            "has finished in ", "has left with ", "hides in ", "is attacked by ",
            "is commanded by ", "is concerned about ", "is contaminated by ",
            "is destroyed by ", "is distressed by ", "is financed by ",
            "is fondled by ", "is found by ", "is imitated by ", "is infiltrated by ",
            "is joined by ", "is like a god to ", "is removed by ",
            "is the patron of ", "is threatened by ", "listens to ", "makes fun of ",
            "may not visit ", "moves to ", "originates from ", "reports to ",
            "retreats from ", "returns to ", "shoots henchmen of ",
            "should watch for ", "steals from ", "takes blame for ",
            "takes control of ", "takes no notice of ", "takes refuge in ",
            "travels to ", "walks to ", "was eliminated by ", "was seen in ",
            "will go to ", "withdraws from ", "assumed responsibility for ",
            "avoided servants of ","has dealt with ", "eloped with ",
            "evaded agents of ", "fled from ", "fled to ", "flew to ",
            "flew toward ", "has gone for ", "went to ", "hides in ",
            "was attacked by ", "was commanded by ", "was concerned about ",
            "was contaminated by ", "was destroyed by ", "was distressed by ",
            "was financed by ", "was fondled by ", "was found by ",
            "was imitated by ", "was infiltrated by ", "was joined by ",
            "was removed by ", "was the patron of ", "was threatened by ",
            "listened to ", "made fun of ", "moved to ", "originated from ",
            "reported to ", "retreated from ", "returned to ", "shot henchmen of ",
            "watched for ", "stole from ", "took blame for ", "took control of ",
            "took no notice of ", "took refuge in ", "traveled to ",
            "walked to ","withdrew from ", "plays with ", "played with ",
            "is assassinated by ", "was assassinated by ", "is boggled by ",
            "was boggled by ", "performs surgical alternations on "
            };

        private String[] actions = {
            "amuses ", "avoids ", "berates ", "boggles ", "bothers ",
            "buries ", "catches ", "commands ", "contaminates ", "controls ",
            "converts ", "delivers ", "destroys ", "disfigures ", "eats ", "enters ",
            "fondles ", "handles ", "harasses ", "hassles ", "helps ",
            "imitates ", "infiltrates ", "inherits ", "joins ", "kills ", "leaves ",
            "massages ", "molests ", "persuades ", "perverts ", "pitches ",
            "rebuilds ", "reinforces ", "removes ", "replaces ", "resurrects ",
            "saves ", "serves ", "spanks ", "squeezes ", "strokes ", "subverts ",
            "swallows ", "swats ", "torments ", "tortures ", "transforms ",
            "whips ","teases ", "stomps ", "mates with ", "tickles ", "audits ",
            "beats ", "defeats ", "outwits ","manipulates ", "defects to ",
            "titillates ", "perverts ", "defenestrates ", "discards ",
            "abandons ", "talks to ", "talks back to ", "allies with ",
            "discovers ", "betrays ", "assassinates ", "promotes ",
            "pretends to be ", "disguises ", "disobeys ", "alters ",
            "intimidates "
            };

        private String[] pronouns = { "his ", "my ", "our ", "the ", "your " };

        private String[] intros = {
            "4 out of 5 dentists recommend that ","Abort immediately unless ",
            "Abort previous sequence. ","Advance code sequence. ",
            "Alert all stations! ","Confirmed report: ",
            "Contrary to popular belief, ","Delete all evidence that ",
            "Determine whether ","E.F. Hutton says ","Effective immediately, ",
            "Enemy agents now know that ","Fnord! ","Follow plan x if ",
            "Ignore previous message. ","Ignore this message. ","Imperative that ",
            "It appears that ","It is not true that ",
            "Most people surveyed believe that ","Observe and report if ",
            "Oral Roberts dreamed that ","Our foes believe that ",
            "Our reporters claim that ","Pentagon officials deny that ",
            "Please investigate report that ","Step up operation. ",
            "Terminate operation if ", "The surgeon general warns that ",
            "Unsubstantiated rumor: ","Urgent! ","Usual sources confirm that ",
            "Warning! ","We suspect that "
            };

        private String[] nouns = {
            "911 file ", "(censored) ", "amethyst ", 
            "amulet ", "ash tray ", "baby ", "BBS ", "beer bottle ", "blueprint ",
            "boat ", "book ", "bowling ball ", "business card ", "button ", "cable ",
            "cactus ", "cannibal ", "capsule ", "carnation ", "cash ", "cat ",
            "cauliflower ", "chainsaw ", "chair ", "chicken ", "club ", "cockroach ",
            "code wheel ", "coke can ", "compact disc ", "computer ", "cork ",
            "couch ", "cow ", "crystal ", "cummerbund ",
            "cyberdeck ", "demon ", "devil ", "diamond ", "dictaphone ", "dictator ",
            "dinosaur ", "disk drive ", "document ", "dragon ", "drug ", "duck ",
            "elephant ", "engine ", "eye ", "file ", "flag ", "floppy disk ",
            "fly ", "football ", "frame ", "frog ", "geographer ", "goldfish ",
            "grasshopper ", "grimoire ", "gyroslugger ", "hammer ", "hat ",
            "hat-rack ", "helmet ", "hemisphere ", "hot tub ", "hypodermic ",
            "ice cream ", "ID card ", "iguana ", "implement ", "infant ", "insect ",
            "jellybean ", "jet ", "jet ski ", "jukebox ", "kitten ", "Klingon ",
            "krugerrand ", "kumquat ", "lamp ", "light bulb ", "machine gun ",
            "mallet ", "manuscript ", "mason jar ", "message ", "mosquito ",
            "motorcycle ", "mouse ", "oar ", "octopus ", "olive ", "ostrich ",
            "paddle ", "paintbrush ", "paper clip ", "passport ", "password file ",
            "password ", "pendant ", "penguin ", "petunia ", "phased plasma rifle ",
            "phone ", "photocopy ", "piranha ", "pistol ", "pit viper ", "plant ",
            "playtester ", "pop tart ", "power drill ", "ptarmigan ", "pterodactyl ",
            "puppy ", "pyramid ", "racquetball ", "radio ", "railroad ", "razor ",
            "rescuer ", "ring ", "rom chip ", "saber ", "saxophone ", "scenario ",
            "scraper ", "screwdriver ", "scuba mask ", "sculpture ", "sex toy ",
            "shark ", "shoggoth ", "skateboard ", "ski lift ", "skillet ",
            "spark plug ", "spider ", "submarine ", "surfboard ", "sword ", 
            "teddy bear ", "telegram ", "television ", "tennis ball ", "termite ", 
            "textbook ", "toast ", "tornado ", "traitor ", "transmitter ", 
            "treasure chest ", "tree ", "trolley ", "trumpet ", "typewriter ", 
            "user's manual ", "Uzi ", "van ", "virus ", "volleyball ", "wand ", 
            "wheel ", "whip ", "yak ", "Zulu ","INWO deck ", "ukelele ", "icon ",
            "amphibian ", "toad ", "terminal ", "additive ", "piccolo ", "tuba ", 
            "angel ", "demon ", "CD-ROM ", "DVD ", "Deep One ", "Handheld ", "MP3 ",
            "Segway ", "dog ", "iMac ", "laptop ", "nanite ", "iPhone"
            };

        private String[] modifiers = {
            "apparently ", "barely ", "definitely ", "disgustingly ", "far too ",
            "much too ", "not ", "probably ", "secretly ", "slightly ", "too "
            };

        private String[] infinitives = {
            "amuse ", "avoid ", "berate ", "boggle ", "bother ", "bury ",
            "catch ", "command ", "contaminate ", "control ", "convert ", "deliver ",
            "destroy ", "disfigure ", "dissolve ","eat ", "enter ", "fondle ", "handle ",
            "harass ", "hassle ", "help ", "imitate ", "infiltrate ", "inherits ",
            "join ", "kill ", "kiss ", "leave ", "love ", "massage ", "molest ",
            "persuade ", "pervert ",
            "pitche ", "rebuild ", "reinforce ", "remove ", "replace ", "resurrect ",
            "save ", "serve ", "spank ", "squeezes ", "stroke ", "subvert ",
            "swallow ", "swat ", "swim ", "torment ", "torture ", "transform ", "whip "
            };

        private String[] abilities = {
            "can ", "cannot ", "will ", "will not ", "should ", "should not ",
            "must ", "must not ", "will probably ", "will probably not ",
            "doesn't ", "wants to ", "is afraid to ", "is ordered to "
            };

        // Initialize random object
        private Random r = new Random();

        // String to contain the message being created
        private StringBuilder message = new StringBuilder(200);

        //
        // Private methods
        //

        // Functions to retrieve strings from arrays to save some typing
        private string getAdjective()
        {
            return adjectives[r.Next(adjectives.Length)];
        }

        private string getName()
        {
            return names[r.Next(names.Length)];
        }

        private string getPlace()
        {
            return places[r.Next(places.Length)];
        }

        private string getPreposition()
        {
            return prepositions[r.Next(prepositions.Length)];
        }

        private string getAction()
        {
            return actions[r.Next(actions.Length)];
        }

        private string getPronoun()
        {
            return pronouns[r.Next(pronouns.Length)];
        }

        private string getIntro()
        {
            return intros[r.Next(intros.Length)];
        }

        private string getNoun()
        {
            return nouns[r.Next(nouns.Length)];
        }

        private string getModifier()
        {
            return modifiers[r.Next(modifiers.Length)];
        }

        private string getInfinitive()
        {
            return infinitives[r.Next(infinitives.Length)];
        }

        private string getAbilitiy()
        {
            return abilities[r.Next(abilities.Length)];
        }

        //
        // Public methods
        //

        public string GetMessage()
        {
            // Make sure message is empty in case GetMessage has been called before
            message.Remove(0, message.Length);

            switch (r.Next(14))
            {
                case 0:
                    // The (<adjective> 50%)<noun> (in <place> 20%) is <adjective>
                    message.Append("The ");
                    if (r.Next(2) == 1)
                    {
                        message.Append(getAdjective());
                    }
                    message.Append(getNoun());
                    if (r.Next(5) == 1)
                    {
                        message.Append("in " + getPlace());
                    }
                    message.Append("is " + getAdjective());
                    break;

                case 1:
                    // <name> <action> the <adjective> <noun> and the <adjective> <noun>
                    message.Append(getName() + getAction() + "the " + getAdjective() + getNoun() + "and the " +
                        getAdjective() + getNoun());
                    break;

                case 2:
                    // The <noun> from <place> will go to <place>
                    message.Append("The " + getNoun() + "from " + getPlace() + "will go to " + getPlace());
                    break;

                case 3:
                    // <name> must take the <adjective> <noun> from <place>
                    message.Append(getName() + "must take the " + getAdjective() + getNoun() + "from " + getPlace());
                    break;

                case 4:
                    // <place> is <adjective> and the <noun> is <adjective>
                    message.Append(getPlace() + "is " + getAdjective() + "and the " + getNoun() + "is " + getAdjective());
                    break;

                case 5:
                    // <name> <preposition> <place> for the <adjective> <noun>
                    message.Append(getName() + getPreposition() + getPlace() + "for the " + getAdjective() + getNoun());
                    break;

                case 6:
                    // the (<adjective>  50%) <noun> <action> the <adjective> <noun> (in <place> 20%)
                    message.Append("The ");
                    if (r.Next(2) == 1)
                    {
                        message.Append(getAdjective());
                    }
                    message.Append(getName() + getAction() + "the " + getAdjective() + getNoun());
                    if (r.Next(5) == 1)
                    {
                        message.Append("in " + getPlace());
                    }
                    break;

                case 7:
                    // <name> <preposition> <place> and <action> the <noun>
                    message.Append(getName() + getPreposition() + getPlace() + "and " + getAction() + "the " + getNoun());
                    break;

                case 8:
                    // <name> takes <pronoun> (<adjective> 50%) <noun> and <preposition> <place>
                    message.Append(getName() + "takes " + getPronoun());
                    if (r.Next(2) == 1)
                    {
                        message.Append(getAdjective());
                    }
                    message.Append(getNoun() + "and " + getPreposition() + getPlace());
                    break;

                case 9:
                    // <name> <action> the (<adjective 50%) <noun>
                    message.Append(getName() + getAction() + "the ");
                    if (r.Next(2) == 1)
                    {
                        message.Append(getAdjective());
                    }
                    message.Append(getNoun());
                    break;

                case 10:
                    // <name> <action> <name> and <pronoun> (<adjective> 50%) <noun>
                    message.Append(getName() + getAction() + getName() + "and " + getPronoun());
                    if (r.Next(2) == 1)
                    {
                        message.Append(getAdjective());
                    }
                    message.Append(getNoun());
                    break;

                case 11:
                    // <name> is the (<adjective> 50%) <noun>; <name> <preposition> <place>
                    message.Append(getName() + "is the ");
                    if (r.Next(2) == 1)
                    {
                        message.Append(getAdjective());
                    }
                    message.Append(getNoun());
                    message.Remove(message.Length - 1, 1);
                    message.Append("; " + getName() + getPreposition() + getPlace());
                    break;

                case 12:
                    // You must meet <name> at <place> and get the (<adjective> 50%) <noun>
                    message.Append("You must meet " + getName() + "at " + getPlace() + "and get the ");
                    if (r.Next(2) == 1)
                    {
                        message.Append(getAdjective());
                    }
                    message.Append(getNoun());
                    break;

                case 13:
                    // A <noun> from <place> <action> the  (<adjective> 50%) (<adjective> 20%) <noun>
                    message.Append("A " + getNoun() + "from " + getPlace() + getAction() + "the ");
                    if (r.Next(2) == 1)
                    {
                        message.Append(getAdjective());
                    }
                    if (r.Next(5) == 1)
                    {
                        message.Append(getAdjective());
                    }
                    message.Append(getNoun());
                    break;

                default:
                    message.Append("Fnord!");
                    break;
            }

            // Replace trailing space with a period
            message.Replace(' ', '.', (message.Length - 1), 1);
            
            // Convert first letter of message to upper case
            message[0] = Char.ToUpper(message[0]);

            // return the message as a string
            return message.ToString();
        }
    }
}