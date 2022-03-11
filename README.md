<div id="top"></div>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->

[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://telesoftas.com/">
  <img src="images/telesoftas.png" alt="Logo" >
  </a>

  <h3 align="center">Text-Wrapping Assignment</h3>

  <p align="center">
    A take home test on text wrapping 
    <br />
    <a href="https://github.com/migellars/TextWrapping/issues">Report Bug</a>
    ·
    <a href="https://github.com/migellars/TextWrapping/issues">Request Feature</a>
  </p>
</div>


<!-- ABOUT THE PROJECT -->
## About The Project

[![Product Name Screen Shot][product-screenshot]](https://telesoftas.com)

Maintaining standard practise is not repeating yourself in a code, while working on this Algorithm i had guide from the internet  `Andersson Johan` implementation worked to an extent but i had to better the implementation to suite my need.


What was done:
* Get in list of data
* validate list of data
* Get in limit for data
* Validate limit of data
* Identify current inex of data and maintain the last wrap state
* A do while iteration that determine the current index
    * if lastwrap + the limit been passed is greater than the length of data been passed return data been passed
    * else check if the data been passed has a last index of any of `{ ',', '.', '?', '!', ':', ';', '-', '\n', '\r', '\t' }` then get the minimum value between of length of data -1 and lastwrap + limit.
    * if current index is less than lastwrap or equal to last wrap then
        * current index is equal to minimum value of lastwarp + limit and length of data.
    * add data to the list of data and get the substring of the data
* You should implement DRY principles to the rest of your life :smile:

Of course the implementation is online, but tweaking and understanding how to make it work is also a challenge, appreciation to `Andersson Johan` for taking time to write the algorithm over 9yrs ago. Hopefully this secures the goal.
<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this code better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#top">back to top</a>)</p>


<!-- CONTACT -->
## Contact

Michael - [@strtDev](https://twitter.com/strtDev) - migellars@gmail.com

Project Link: [https://github.com/migellats/TextWrapping](https://github.com/migellars/TextWrapping)

<p align="right">(<a href="#top">back to top</a>)</p>


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/migel1234
[product-screenshot]: images/screenshot.png