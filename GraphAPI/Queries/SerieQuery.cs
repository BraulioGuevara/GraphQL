
using GraphAPI.Models;

namespace GraphAPI.Queries
{
    public class SerieQuery
    {

        public Serie GetSerie()
        {
            return new Serie{

                Name = "One Piece",
                ReleaseDate = DateTime.UtcNow.AddDays(-10),
                Platforms= new List<Plataforma>
                {
                    new()
                    {
                        Name = "Crunchy",
                        Followers = 100,
                    },
                    new(){
                        Name = "Funimation",
                        Followers = 0
                    }
                    
                }
             };
        }


        public Series GetSeries(){
            return new Series{

             ListaSeries = new List<Serie>{
                    new(){
                        Name = "adadsa",
                        ReleaseDate = DateTime.UtcNow.AddDays(-10),
                        Platforms = new List<Plataforma> {
                                new(){
                                    Name = "Netflix",
                                    Followers = 30
                                },
                                new(){
                                    Name = "Crunchy",
                                    Followers = 53
                                }
                        } 
                    },
                    new(){
                        Name = "adadsa",
                        ReleaseDate = DateTime.UtcNow.AddDays(-10),
                        Platforms = new List<Plataforma> {
                                new(){
                                    Name = "Netflix",
                                    Followers = 30
                                },
                                new(){
                                    Name = "Crunchy",
                                    Followers = 53
                                }
                        } 
                    },
                    new(){
                        Name = "adadsa",
                        ReleaseDate = DateTime.UtcNow.AddDays(-10),
                        Platforms = new List<Plataforma> {
                                new(){
                                    Name = "Netflix",
                                    Followers = 30
                                },
                                new(){
                                    Name = "Crunchy",
                                    Followers = 53
                                }
                        } 
                    }
                }
            };

        }


        public Serie[] GetArray(){
            return new Serie[]{
                new(){
                    Name = "adadsa",
                    ReleaseDate = DateTime.UtcNow.AddDays(-10),
                    Platforms = new List<Plataforma> {
                        new(){
                            Name = "Netflix",
                            Followers = 30
                        },
                        new(){
                            Name = "Crunchy",
                            Followers = 53
                        }
                    } 
                },
                new(){
                    Name = "adadsa",
                    ReleaseDate = DateTime.UtcNow.AddDays(-10),
                    Platforms = new List<Plataforma> {
                        new(){
                            Name = "Netflix",
                            Followers = 30
                        },
                        new(){
                            Name = "Crunchy",
                            Followers = 53
                        }
                    } 
                },
                new(){
                    Name = "adadsa",
                    ReleaseDate = DateTime.UtcNow.AddDays(-10),
                    Platforms = new List<Plataforma> {
                        new(){
                            Name = "Netflix",
                            Followers = 30
                        },
                        new(){
                            Name = "Crunchy",
                            Followers = 53
                        }
                    }
                }
            };
        }

        public Serie GetElement(int i){
            Serie[] serie = GetArray();
            return serie[i];
        }
        
    }
}