﻿namespace Netflix.Content.Dtos.SeasonDto
{
    public class GetByIdSeasonDto
    {
        public int SeasonId { get; set; } // Sezon ID
        public int SeriesId { get; set; } // Hangi diziye ait olduğu
        public int SeasonNumber { get; set; } // Sezon numarası
        public int EpisodeCount { get; set; } // Toplam bölüm sayısı
    }
}