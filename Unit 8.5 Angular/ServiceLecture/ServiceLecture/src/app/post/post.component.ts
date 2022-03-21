import { Component, Input, OnInit } from '@angular/core';
import { Post } from '../blog';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css']
})
export class PostComponent implements OnInit {
  @Input() post: Post = {} as Post;
  constructor() { }

  ngOnInit(): void {
  }

}
