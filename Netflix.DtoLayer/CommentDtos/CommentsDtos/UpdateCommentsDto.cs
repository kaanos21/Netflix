﻿namespace Netflix.DtoLayer.CommentDtos.CommentsDtos
{
    public class UpdateCommentsDto
    {
        public int CommentsId { get; set; }
        public int ContentId { get; set; }
        public string Name { get; set; }
        public string CommentText { get; set; }
        public DateTime Date { get; set; }
    }
}
