import React from "react";
import { Container, Row, Col } from "reactstrap";
import gp_bg from "../assets/images/statsbg.jpg";

import eventsCompletedBg from "../assets/images/bg_small_stat_01.jpg";
import distanceCovered from "../assets/images/bg_small_stat_02.jpg";
import flags from "../assets/images/icon_flags.png";
import route from "../assets/images/icon_distance.png";

import clock from "../assets/images/icon_time.png";
import cup from "../assets/images/icon_cup.png";
import abutrack from "../assets/images/track_spline_abudhabi.png";
import "./GridContainer.css";

export const GridContainer = () => {
  const leftContent = () => (
    <React.Fragment>
      <Row noGutters={true}>
        <Col xs="12">
          <div className="gps grid-box">
            <h1 style={{ paddingTop: "7%" }}>689,563</h1>
            <h3>Grand Prix this week</h3>
          </div>
        </Col>
      </Row>
      <Row noGutters={true}>
        <Col xs="6">
          <div className="events-complete grid-box">
            <img
              style={{ padding: "5%", height: "60%" }}
              src={flags}
              alt="flag"
            />
            <h5>22,600</h5>
            RaceNet Events Complete
          </div>
        </Col>
        <Col noGutters={true} xs="6">
          <div className="distance-covered grid-box">
            <img
              style={{ padding: "5%", height: "60%" }}
              src={route}
              alt="distance"
            />
            <h5>459,826 mi</h5>
            Distance Covered
          </div>
        </Col>
      </Row>
    </React.Fragment>
  );

  const track = () => (
    <React.Fragment>
      <Row noGutters={true}>
        <Col xs="12">
          <div className="track grid-box">
            <div style={{ paddingTop: "7%" }}>Favorite Track</div>
            <h2>Abu Dhabi</h2>
            <img style={{ width: "75%" }} src={abutrack} alt="Abu Dhabi" />
          </div>
        </Col>
      </Row>
    </React.Fragment>
  );

  const rightContent = () => (
    <React.Fragment>
      <Row noGutters={true}>
        <Col xs="6">
          <div className="events-complete grid-box">
            <img
              style={{ padding: "5%", height: "60%" }}
              src={cup}
              alt="cup"
            />
            <h5>259,877</h5>
            Winners
          </div>
        </Col>
        <Col xs="6">
          <div className="distance-covered grid-box">
            <img
              style={{ padding: "5%", height: "60%" }}
              src={clock}
              alt="clock"
            />
            <h5>4 Days 8 Hours</h5>
            Spent Racing
          </div>
        </Col>
      </Row>
      <Row noGutters={true}>
        <Col xs="12">
          <div className="buy-now grid-box">
           <h5 style={{position:"relative", top:"80%"}}> 
               <a className="site-link" href="#">Visit F1 2018's Website</a>
            </h5>
          </div>
        </Col>
      </Row>
    </React.Fragment>
  );

  return (
    <div>
      <Container>
        <Row noGutters={true}>
          <Col xs="12" sm="4">
            {leftContent()}
          </Col>
          <Col xs="12" sm="4">
            {track()}
          </Col>
          <Col xs="12" sm="4">
            {rightContent()}
          </Col>
        </Row>
      </Container>
    </div>
  );
};
