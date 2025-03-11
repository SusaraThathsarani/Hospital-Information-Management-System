import React from "react";
import './About.css';

const About = () => {
  return (
    <section id="about" className="about">
      <h1 className="heading">About Our Facility</h1>
      <h2 className="title">Learn and Explore Our Facility</h2>

      <div className="box-container">
        {/* Ambulance Services */}
        <div className="box">
          <div className="images">
            <img
              src="https://media.istockphoto.com/id/936280572/video/paramedics-loading-the-injured-person-into-the-ambulance.jpg?s=640x640&k=20&c=anz5nsLq7ghVUMEGZM8er70grAyWjvfo64ivniLtHHI="
              alt="Ambulance Services"
            />
          </div>
          <div className="content">
            <h3>Ambulance Services</h3>
            <p>Ambulance services provide rapid medical transport and care during emergencies.</p>
            <a href="#"><button className="button">Learn More</button></a>
          </div>
        </div>

        {/* Free Checkup */}
        <div className="box">
          <div className="images">
            <img
              src="https://images.unsplash.com/photo-1576091160550-2173dba999ef?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80"
              alt="Free Checkup"
            />
          </div>
          <div className="content">
            <h3>Free Checkup</h3>
            <p>
              Free checkups are vital for early disease detection and preventative care. They offer basic health
              screenings and advice, empowering individuals to manage their well-being and promoting public health,
              all without financial burden.
            </p>
            <a href="#"><button className="button">Learn More</button></a>
          </div>
        </div>

        {/* Emergency Rooms */}
        <div className="box">
          <div className="images">
            <img
              src="https://images.unsplash.com/photo-1584432810601-6c7f27d2362b?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80"
              alt="Emergency Rooms"
            />
          </div>
          <div className="content">
            <h3>Emergency Rooms</h3>
            <p>
              Emergency rooms (ERs) provide immediate medical care for life-threatening conditions. They're staffed,
              handling trauma, acute illnesses, and injuries requiring urgent attention. ERs prioritize patients based on
              severity, ensuring the most critical cases are treated first.
            </p>
            <a href="#"><button className="button">Learn More</button></a>
          </div>
        </div>
      </div>
    </section>
  );
};

export default About;