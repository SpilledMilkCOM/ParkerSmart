# <img alt="Parker Smart Logo" src="https://github.com/SpilledMilkCOM/SpilledMilkCOM/blob/master/images/PDS.png?raw=true" width="30px" /> [ParkerSmart.com](http://ParkerSmart.com)
The personal website of Parker Smart.  Lists web presence, work, dev, and game achievements.

GoDaddy does NOT support .Net Core on their PLESK servers so I had to revert back to .Net MVC.
Oh well, I'm not paying for their VPN service especially when I only have FREE sites.

## 🏫 A Few Things Learned When Developing This Site

* [Bootstrap](https://getbootstrap.com/2.3.2/) 3 (version 2.3.2 and up)
  * Understanding columns and nested columns
* Embedding Tweets and Twitter feed
* Embedding YouTube videos
* Converting to [Bootstrap](https://getbootstrap.com) 4
  * Adjusting the `navbar` elements.
  * Replace "img-responsive" with "img-fluid"
  * Replace `glyphicon` with [Iconic](https://useiconic.com/) (~$40 - Do I have to give them a shoutout on
    my site if I **pay** for these their fonts?) I think all I'm using right now is their envelop...  Was **THAT**
    worth forty bucks?
  * Adjusting the columns and nested columns.
  * The [commit](https://github.com/SpilledMilkCOM/ParkerSmart/commit/b3a1ff08181d6dcb044fe1440812f99c8cc60512)
    that has all the conversions.
  * Using the [**New Order**](https://www.w3schools.com/bootstrap4/bootstrap_grid_system.asp) versus push/pull in Bootstrap 3
  * Reference the `Scripts/umd/popper.js` instead of just `Scripts/umd/popper.js` otherwise you see errors logged and tooltips will NOT work.
* Here are the image requirements specific to the **LinkedIn** sharing module:
  * Max file size: 5 MB
  * Minimum image dimensions: 1200 (w) x 627 (h) pixels
  * Recommended ratio: 1.91:1
* Automatically redirect to the HTTPS site if given the HTTP prefix.
  * Adjust the web.Release.config and add transforms to add the rules found [here](https://www.godaddy.com/help/redirect-http-to-https-automatically-8828).
  * Used the **PLESK** option in the list on the page above.

## 📚 References

* Bootstrap 4 Icons - https://useiconic.com/
* Bootstrap 4 Grids - https://www.w3schools.com/bootstrap4/bootstrap_grid_system.asp
* Twitter - https://developer.twitter.com/en
* Emoji - https://www.w3schools.com/charsets/ref_emoji.asp
* `linear-gradient` - https://developer.mozilla.org/en-US/docs/Web/CSS/linear-gradient
* Processing (p5.js) - https://p5js.org/
* Device Orientation - https://developers.google.com/web/fundamentals/native-hardware/device-orientation/
* [Making Your Website Shareable on LinkedIn](https://www.linkedin.com/help/linkedin/answer/46687/making-your-website-shareable-on-linkedin?lang=en)