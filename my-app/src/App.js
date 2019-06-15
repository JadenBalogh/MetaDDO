import React from 'react';
import logo from './logo.svg';
import './App.css';
import { withFirebase } from './components/Firebase';

// https://reactjs.org/docs/components-and-props.html

class Effect extends React.Component {
  constructor(props) {
    super(props);
    this.state = {val: 10};
    this.handleChange = this.handleChange.bind(this);
  }
  
  handleChange(e) {
    var bonus = e.target.value;
    this.props.onEffectChange(this.props.id, bonus);
    //this.setState({ val: newVal });
  }

  render() {
    return (
      <div className="slider-container">
        <p className="slider-name">{this.props.name}</p>
        <p className="slider-value">{this.props.bonus}</p>
        <input 
          className="slider-bar"
          type="range"
          min="0"
          max="10"
          value={this.props.bonus}
          onChange={this.handleChange}
        />
      </div>
    );
  }
}

function EffectList(props) {
  const effectList = props.effects.map(
    effect => 
    <Effect
      key={effect.id}
      id={effect.id}
      name={effect.name}
      bonus={effect.bonus}
      onEffectChange={props.onEffectChange}
    />
  );
  return (
    effectList
  );
}

class EffectFormBase extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      effects: []
    };
    
    this.onEffectChange = this.onEffectChange.bind(this);
    this.handleSubmit = this.handleSubmit.bind(this);
  }

  async initializeEffects() {
    var result = [];
    this.props.firebase.getEffects()
      .then(effects => {
        effects.docs.forEach(effect => {
          var instance = effect.data();
          instance['id'] = effect.id;
          instance['name'] = await getStatName(instance['statNameID']);
          result.push(instance);
        });
        this.setState({
          effects: result
        });
      });
  }

  async getStatName(statNameID) {
    this.props.firebase.getStatName(statNameID)
      .then(statName => {
        return statName.data().name;
      });
  }

  componentDidMount() {
    initializeEffects();
  }

  onEffectChange(id, bonus) {
    var newEffects = this.state.effects.slice();
    var i = newEffects.findIndex(x => x.id == id);
    newEffects[i].bonus = bonus;
    this.setState({
      effects: newEffects
    });
  }

  handleSubmit(e) {
    e.preventDefault();
    console.log(this.state.effects);
  }

  render() {
    return (
      <form onSubmit={this.handleSubmit}>
        <EffectList
          effects={this.state.effects}
          onEffectChange={this.onEffectChange}
        />
        <input
          className="submit-button"
          type="submit"
          value="Submit Data"
        />
      </form>
    );
  }
}

const EffectForm = withFirebase(EffectFormBase);

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <EffectForm />
      </header>
    </div>
  );
}

export default App;
