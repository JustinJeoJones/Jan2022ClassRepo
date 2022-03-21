import { Component, OnInit } from '@angular/core';
import { Blog, Post } from '../blog';
import { BlogService } from '../blog.service';

@Component({
  selector: 'app-blog',
  templateUrl: './blog.component.html',
  styleUrls: ['./blog.component.css']
})
export class BlogComponent implements OnInit {

  result:Blog = {} as Blog;
  constructor(private blogService:BlogService) { }

  ngOnInit(): void {

    this.blogService.getBlogPosts().subscribe((response: Blog) => {
      this.result = response;
      // console.log(response.title);
      // console.log(response.language);
      // console.log(response.posts.length);
      // console.log(response.posts[0].title);
      // response.posts.forEach(p => console.log(p.title));

      // response.posts.forEach((p:Post) =>{
      //   p.tags.forEach(t => console.log(t));
      // });

    });

  }

}
