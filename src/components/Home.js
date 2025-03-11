import React from "react";
import "./Home.css";

const Home = () => {
  return (
    <section id="home" className="home">
      <div className="row">
        {/* Home images */}
        <div className="images">
          <img
            src="https://th.bing.com/th/id/OIP.Wo8Uaroy1zjnax8AH6aAUgHaE8?w=265&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7"
            alt="Healthcare"
            className="home-img"
          />
        </div>

        {/* Home heading */}
        <div className="content">
          <h1>
            <span>Stay</span> Safe, <span>Stay</span> Healthy.
          </h1>
          <p>
            Our HIMS promotes 'stay safe, stay healthy' by securing patient data
            and enabling accurate, efficient care.
          </p>
          <a href="#">
            <button className="button">Read More</button>
          </a>
        </div>
      </div>
    </section>
  );
};

export default Home;
