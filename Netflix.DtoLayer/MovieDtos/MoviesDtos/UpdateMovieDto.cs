﻿namespace Netflix.DtoLayer.MovieDtos.MoviesDtos
{
    public class UpdateMovieDto
    {
        public int MoviesId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }
    }
}