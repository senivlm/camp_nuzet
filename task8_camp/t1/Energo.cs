using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task6_1
{
    public class Energo
    {
        public string _path { get; private set; }

        public int _numbersOfFlats;
        public int NumbersOfFlat
        {
            get { return _numbersOfFlats; }
            set
            {
                if (value >= 0)
                {
                    _numbersOfFlats = value;
                }
            }
        }

        private int _blockNumber;

        public int BlockNumber
        {
            get { return _blockNumber; }
            set
            {
                if (value >= 1 && value <= 4)
                {
                    _blockNumber = value;
                }
            }
        }

        private List<Flat> _flats;

        private Energo()
        {
            _flats = new List<Flat>();
        }

        public Energo(string fileName) : this()
        {
            _path = fileName;
        }
        public void ShowInfo()
        {
            foreach (Flat flat in _flats)
            {
                Console.WriteLine(flat);
            }
        }
        public void InputInfoFromFile()
        {
            try
            {
                StreamReader reader = new StreamReader(_path);

                //int line = 1;

                string[] lines = reader.ReadLine().Split(" ");

                if (!int.TryParse(lines[0], out _numbersOfFlats))
                {
                    Console.WriteLine("error! can`t read from file");
                }
                if (!int.TryParse(lines[1], out _blockNumber))
                {
                    Console.WriteLine("error! can`t read from file");
                }
                //line++;

                while (!reader.EndOfStream)
                {
                    lines = reader.ReadLine().Split(" ");
                    try
                    {
                        _flats.Add(new Flat(int.Parse(lines[0]), lines[1], double.Parse(lines[2]), double.Parse(lines[3]), DateTime.Parse(lines[4])));
                        //line++;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("error! can`t read from file");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File is not found!");
            }
            catch (IOException)
            {
                Console.WriteLine("general exception!");
            }
        }

        public void NotUsedElectricity()
        {
            foreach (var flat in _flats)
            {
                if (flat.UsedEnergy == 0)
                {
                    Console.WriteLine($"Flat number: {flat.Number}\t Flat owner: {flat.NameOwner} || dosen`t use electricity");
                }
            }
        }

        public void TheMostElectricityUses()
        {
            Flat flatMostEnergyUsed = _flats[0];
            foreach (var flat in _flats)
            {
                if (flat.UsedEnergy > flatMostEnergyUsed.UsedEnergy)
                {
                    flatMostEnergyUsed = flat;
                }
            }
            Console.WriteLine($"The most electricity used: {flatMostEnergyUsed}");
        }


        public void Pay()
        {
            foreach (var flat in _flats)
            {
                Console.WriteLine($"Flat number:{flat.Number} \t Flat owner: {flat.NameOwner} \t need to pay {flat.UsedEnergy * 3}$");
            }
        }

        public void InfoToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine($"Block: {BlockNumber} Number of flats: {NumbersOfFlat}");
                foreach (var flat in _flats)
                {
                    writer.WriteLine(flat);
                }
            }
        }

        public static List<Flat> operator+ (Energo a, Energo b)
        {// навіщо toList?
            List<Flat> _flatsResult  = b._flats.ToList();
            // множини були ефективніші
            foreach (var flat in a._flats)
            {
                if(!b._flats.Any(b =>b.Number==flat.Number&&b.NameOwner ==flat.NameOwner))
                {
                    _flatsResult.Add(flat);
                }
            }
            return _flatsResult;

        }

        public static  List <Flat> operator- (Energo a , Energo b)
        {
            List<Flat> _flats = a._flats.ToList();
            foreach(var flat in a._flats)
            {
                if (!b._flats.Any(b => b.Number == flat.Number && b.NameOwner == flat.NameOwner))
                {
                    _flats.Remove(flat);
                }
            }
            return _flats;

        }



        
    }
}
