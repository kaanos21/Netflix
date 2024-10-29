﻿namespace Netflix.Content.Dtos.EpisodeDto
{
    public class GetByIdEpisodeDto
    {
        public int EpisodeId { get; set; } // Bölüm ID
        public int SeasonId { get; set; } // Bölüm ID
        public int EpisodeNumber { get; set; } // Bölüm numarası
        public string Title { get; set; } // Bölüm başlığı
        public int Duration { get; set; } // Bölüm süresi
        public DateTime ReleaseDate { get; set; } // Yayın tarihi
        public string StreamFileUrl { get; set; } // Akış dosyası URL'si
    }
}