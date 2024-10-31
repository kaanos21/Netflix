﻿namespace Netflix.DtoLayer.LanguagesDtos.SubtitleDtos
{
    public class GetSubtitlesWithLanguageByContentIdDto
    {
        public int SubtitlesId { get; set; }
        public int ContentId { get; set; }
        public int LanguageId { get; set; }
        public string SubtitleFileUrl { get; set; }
        public string LanguageName { get; set; }
    }
}