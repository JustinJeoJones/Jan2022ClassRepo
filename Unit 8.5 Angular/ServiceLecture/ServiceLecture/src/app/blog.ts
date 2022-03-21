export interface Blog {
    title:    string;
    language: string;
    posts:    Post[];
}

export interface Post {
    title:   string;
    author:  string;
    content: string;
    date:    string;
    tags:    string[];
}
