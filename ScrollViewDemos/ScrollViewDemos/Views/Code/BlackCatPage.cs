﻿namespace ScrollViewDemos.Views.Code
{
    public class BlackCatPage : ContentPage
    {
        public BlackCatPage()
        {
            Label titleLabel = new Label
            {
                Text = "THE BLACK CAT by Edgar Allan Poe",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Label finalLabel = new Label
            {
                Text = "In the meantime the cat slowly recovered. The socket of the lost eye presented, it is true, a frightful appearance, but he no longer appeared to suffer any pain. He went about the house as usual, but, as might be expected, fled in extreme terror at my approach. I had so much of my old heart left, as to be at first grieved by this evident dislike on the part of a creature which had once so loved me. But this feeling soon gave place to irritation. And then came, as if to my final and irrevocable overthrow, the spirit of PERVERSENESS. Of this spirit philosophy takes no account. Yet I am not more sure that my soul lives, than I am that perverseness is one of the primitive impulses of the human heart -- one of the indivisible primary faculties, or sentiments, which give direction to the character of Man. Who has not, a hundred times, found himself committing a vile or a silly action, for no other reason than because he knows he should not? Have we not a perpetual inclination, in the teeth of our best judgment, to violate that which is Law, merely because we understand it to be such? This spirit of perverseness, I say, came to my final overthrow. It was this unfathomable longing of the soul to vex itself -- to offer violence to its own nature -- to do wrong for the wrong's sake only -- that urged me to continue and finally to consummate the injury I had inflicted upon the unoffending brute. One morning, in cool blood, I slipped a noose about its neck and hung it to the limb of a tree; -- hung it with the tears streaming from my eyes, and with the bitterest remorse at my heart; -- hung it because I knew that it had loved me, and because I felt it had given me no reason of offence; -- hung it because I knew that in so doing I was committing a sin -- a deadly sin that would so jeopardize my immortal soul as to place it -- if such a thing were possible -- even beyond the reach of the infinite mercy of the Most Merciful and Most Terrible God."
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            StackLayout stackLayout = new StackLayout();
            stackLayout.Add(new Label { Text = "FOR the most wild, yet most homely narrative which I am about to pen, I neither expect nor solicit belief. Mad indeed would I be to expect it, in a case where my very senses reject their own evidence. Yet, mad am I not -- and very surely do I not dream. But to-morrow I die, and to-day I would unburthen my soul. My immediate purpose is to place before the world, plainly, succinctly, and without comment, a series of mere household events. In their consequences, these events have terrified -- have tortured -- have destroyed me. Yet I will not attempt to expound them. To me, they have presented little but Horror -- to many they will seem less terrible than barroques. Hereafter, perhaps, some intellect may be found which will reduce my phantasm to the common-place -- some intellect more calm, more logical, and far less excitable than my own, which will perceive, in the circumstances I detail with awe, nothing more than an ordinary succession of very natural causes and effects." });
            stackLayout.Add(new Label { Text = "From my infancy I was noted for the docility and humanity of my disposition. My tenderness of heart was even so conspicuous as to make me the jest of my companions. I was especially fond of animals, and was indulged by my parents with a great variety of pets. With these I spent most of my time, and never was so happy as when feeding and caressing them. This peculiarity of character grew with my growth, and, in my manhood, I derived from it one of my principal sources of pleasure. To those who have cherished an affection for a faithful and sagacious dog, I need hardly be at the trouble of explaining the nature or the intensity of the gratification thus derivable. There is something in the unselfish and self-sacrificing love of a brute, which goes directly to the heart of him who has had frequent occasion to test the paltry friendship and gossamer fidelity of mere Man." });
            stackLayout.Add(new Label { Text = "I married early, and was happy to find in my wife a disposition not uncongenial with my own. Observing my partiality for domestic pets, she lost no opportunity of procuring those of the most agreeable kind. We had birds, gold-fish, a fine dog, rabbits, a small monkey, and a cat." });
            stackLayout.Add(new Label { Text = "This latter was a remarkably large and beautiful animal, entirely black, and sagacious to an astonishing degree. In speaking of his intelligence, my wife, who at heart was not a little tinctured with superstition, made frequent allusion to the ancient popular notion, which regarded all black cats as witches in disguise. Not that she was ever serious upon this point -- and I mention the matter at all for no better reason than that it happens, just now, to be remembered." });
            stackLayout.Add(new Label { Text = "Pluto -- this was the cat's name -- was my favorite pet and playmate. I alone fed him, and he attended me wherever I went about the house. It was even with difficulty that I could prevent him from following me through the streets." });
            stackLayout.Add(new Label { Text = "Our friendship lasted, in this manner, for several years, during which my general temperament and character -- through the instrumentality of the Fiend Intemperance -- had (I blush to confess it) experienced a radical alteration for the worse. I grew, day by day, more moody, more irritable, more regardless of the feelings of others. I suffered myself to use intemperate language to my wife. At length, I even offered her personal violence. My pets, of course, were made to feel the change in my disposition. I not only neglected, but ill-used them. For Pluto, however, I still retained sufficient regard to restrain me from maltreating him, as I made no scruple of maltreating the rabbits, the monkey, or even the dog, when by accident, or through affection, they came in my way. But my disease grew upon me -- for what disease is like Alcohol ! -- and at length even Pluto, who was now becoming old, and consequently somewhat peevish -- even Pluto began to experience the effects of my ill temper." });
            stackLayout.Add(new Label { Text = "One night, returning home, much intoxicated, from one of my haunts about town, I fancied that the cat avoided my presence. I seized him; when, in his fright at my violence, he inflicted a slight wound upon my hand with his teeth. The fury of a demon instantly possessed me. I knew myself no longer. My  original soul seemed, at once, to take its flight from my body; and a more than fiendish malevolence, gin-nurtured, thrilled every fibre of my frame. I took from my waistcoat-pocket a pen-knife, opened it, grasped the poor beast by the throat, and deliberately cut one of its eyes from the socket ! I blush, I burn, I shudder, while I pen the damnable atrocity." });
            stackLayout.Add(new Label { Text = "When reason returned with the morning -- when I had slept off the fumes of the night's debauch -- I experienced a sentiment half of horror, half of remorse, for the crime of which I had been guilty; but it was, at best, a feeble and equivocal feeling, and the soul remained untouched. I again plunged into excess, and soon drowned in wine all memory of the deed." });
            stackLayout.Add(finalLabel);

            scrollView.Content = stackLayout;
            scrollView.Scrolled += (s, e) => Console.WriteLine($"ScrollX: {e.ScrollX}, ScrollY: {e.ScrollY}");

            Button button = new Button
            {
                Text = "Scroll to end"
            };
            button.Clicked += async (s, e) => await scrollView.ScrollToAsync(finalLabel, ScrollToPosition.End, true);

            Title = "ScrollView as a child layout demo";
            StackLayout rootStackLayout = new StackLayout
            {
                Margin = new Thickness(20)
            };
            rootStackLayout.Add(titleLabel);
            rootStackLayout.Add(scrollView);
            rootStackLayout.Add(button);

            Content = rootStackLayout;
        }
    }
}
