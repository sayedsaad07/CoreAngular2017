import { Component } from '@angular/core';
import { BlogServcies } from '../../Service/blog.service'
import { Response } from '@angular/http';
import { DonationService } from '../../service/donation.service'


@Component({
    selector: 'blog-detail',
    templateUrl: './blogDetail.component.html',
    providers: [DonationService, BlogServcies ]
})
export class blogDetailComponent {
    public BlogList = [];
    public title: string
    public constructor(private blogService: BlogServcies) {
        this.blogService.getBlogList()
            .subscribe(
            (data: Response) => (this.BlogList = data.json())
        );
        this.title = this.getTitle();

    }  

    getTitle() { return 'Details';}
}
