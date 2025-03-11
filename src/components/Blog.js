import React from 'react';
import "./Blog.css";

const Blog = () => {
    return (
        <section id="blog" className="blog">
            <h1 className="heading">Blog</h1>
            <h3 className="title">Our Facilities</h3>
            <div className="box-container">
                <div className="box">
                    <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTavwmIQuy2yANCYgt1qf0eS-ch548jrk_qeg&s" alt="Diabetes" />
                    <div className="content">
                        <a href="#"><h2>Diabetes</h2></a>
                        <p>Understanding Diabetes: Symptoms, Management, and Prevention.</p>
                        <a href="#"><button className="button">Learn More</button></a>
                    </div>
                </div>
                <div className="box">
                    <img src="https://media.istockphoto.com/id/1181180127/photo/heart-health.jpg?s=612x612&w=0&k=20&c=X81JsSE_VzEyAneS_axQK1HP6T_Lw9klYaDHmViMAQ4=" alt="Heart Checkups" />
                    <div className="content">
                        <a href="#"><h2>Heart Checkups</h2></a>
                        <p>Provide general guidelines on recommended screening frequency based on age and risk factors.</p>
                        <a href="#"><button className="button">Learn More</button></a>
                    </div>
                </div>
                <div className="box">
                    <img src="https://media.istockphoto.com/id/1470546466/photo/healthcare-coronavirus-vaccine-arrangement.jpg?s=612x612&w=0&k=20&c=74rLKD_1g-QikA_bExxxxQfc4XVD8Iq_xxnafGvvyXQ=" alt="Covid-19 Vaccination" />
                    <div className="content">
                        <a href="#"><h2>Covid-19 Vaccination</h2></a>
                        <p>Vaccination is a vital tool in protecting individuals and communities from COVID-19.</p>
                        <a href="#"><button className="button">Learn More</button></a>
                    </div>
                </div>
            </div>
        </section>
    );
};

export default Blog;
