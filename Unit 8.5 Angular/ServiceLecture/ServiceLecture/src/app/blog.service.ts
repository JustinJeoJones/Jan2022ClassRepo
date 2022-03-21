import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BlogService {
  url: string = "https://grandcircusco.github.io/demo-apis/blog-posts.json";
  constructor(private http:HttpClient) { }

  getBlogPosts():any {
    return this.http.get(this.url);
  }
}
