import { Injectable , Inject } from '@angular/core';
import { Http } from '@angular/http';  

@Injectable()
export class BlogServcies {
    constructor(private http: Http, @Inject('ORIGIN_URL') private originUrl: string) {

    }
    getBlogList() {
        return this.http.get(this.originUrl + '/api/blogs');
    }

    getName() {
        //return this.originUrl;
        return 'hellooo Blog service';
    }
} 