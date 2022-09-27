using Microsoft.Toolkit.Mvvm.ComponentModel;
using SuperheroEditor.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroEditor.ViewModels
{
    public class MainWindowViewModel : ObservableRecipient
    {
        public ObservableCollection<Superhero> Barrack { get; set; }
        public ObservableCollection<Superhero> League { get; set; }

        public MainWindowViewModel()
        {
            this.Barrack = new ObservableCollection<Superhero>();
            this.League = new ObservableCollection<Superhero>();

            Barrack.Add(new Superhero()
            {
                Name = "Batman",
                Power = 7,
                Speed = 6,
                Politics = politics.jó
            });

            Barrack.Add(new Superhero()
            {
                Name = "Superman",
                Power = 10,
                Speed = 10,
                Politics = politics.jó
            });

            Barrack.Add(new Superhero()
            {
                Name = "Lex Luthor",
                Power = 8,
                Speed = 4,
                Politics = politics.gonosz
            });

            Barrack.Add(new Superhero()
            {
                Name = "Flash",
                Power = 7,
                Speed = 10,
                Politics = politics.jó
            });


        }
    }
}
