import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { LoggerComponent } from './logger/logger.component';
import { HeroComponent } from './hero/hero.component';
import { HallOfFameComponent } from './hall-of-fame/hall-of-fame.component';
import { BlogComponent } from './blog/blog.component';
import { PostComponent } from './post/post.component';

@NgModule({
  declarations: [
    AppComponent,
    LoggerComponent,
    HeroComponent,
    HallOfFameComponent,
    BlogComponent,
    PostComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
